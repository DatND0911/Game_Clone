#include <iostream>
#include <string>
#include <map>
#include <iterator>
#include <stdlib.h>
#include <unistd.h>
#include <WS2tcpip.h>
#include <sys/socket.h>
#include <sys/types.h>
#include <netinet/in.h>
#include <arpa/inet.h>
#include <ifaddrs.h>
#include <netdb.h>

using namespace std;

class Server
{
 public:
    bool CreateServer() {
        return fasle;
    }
};

class Client
{
 public:
    Socket Client;
    bool ConnectServer() {
        return false;
    }
    
};

class SoketManager
{
public:
    string IP = "127.0.0.1";
    string PORT = "1111";

#pragma region Both

    using byte = unsigned char;
    template <typename T>
    std::array<byte, sizeof(T)> to_bytes(const T &object)
    {
        std::array<byte, sizeof(T)> bytes;

        const byte *begin = reinterpret_cast<const byte *>(std::addressof(object));
        const byte *end = begin + sizeof(T);
        std::copy(begin, end, std::begin(bytes));

        return bytes;
    }

    template <typename T>
    T &from_bytes(const std::array<byte, sizeof(T)> &bytes, T &object)
    {
        static_assert(std::is_trivially_copyable<T>::value, "not a TriviallyCopyable type");

        byte *begin_object = reinterpret_cast<byte *>(std::addressof(object));
        std::copy(std::begin(bytes), std::end(bytes), begin_object);

        return object;
    }

    string GetLocalIPv4(settings_t &ipConfig)
    {
        struct ifaddrs *ifAddrStruct = NULL;
        struct ifaddrs *ifa = NULL;
        void *tmpAddrPtr = NULL;
        string valueIP = "";

        getifaddrs(&ifAddrStruct);

        for (ifa = ifAddrStruct; ifa != NULL; ifa = ifa->ifa_next)
        {
            if (ifa->ifa_addr->sa_family == AF_INET)
            { // check it is IP4
                // is a valid IP4 Address
                tmpAddrPtr = &((struct sockaddr_in *)ifa->ifa_addr)->sin_addr;
                char addressBuffer[INET_ADDRSTRLEN];
                inet_ntop(AF_INET, tmpAddrPtr, addressBuffer, INET_ADDRSTRLEN);

                string key(ifa->ifa_name);
                valueIP = addressBuffer;
                ipConfig.insert(std::pair<string, string>(key, value));
            }
        }
        if (ifAddrStruct != NULL)
            freeifaddrs(ifAddrStruct); // remember to free ifAddrStruct
        return valueIP;
    }

#pragma endregion // Both
};
