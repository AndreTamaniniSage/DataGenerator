using System;

namespace SAGE.BR.HyperCube.data.generator
{
    public static class ServiceConfig
    {
        public const string UrlAdm = "http://ec2co-ecsel-nciy6l1hlzdi-72853533.us-east-1.elb.amazonaws.com:5001";
        public const string UrlHrm = "http://ec2co-ecsel-nciy6l1hlzdi-72853533.us-east-1.elb.amazonaws.com:5002";
        public const string UrlUsm = "http://ec2co-ecsel-nciy6l1hlzdi-72853533.us-east-1.elb.amazonaws.com:5005";

        //public const string UrlAdm = "http://localhost:5001";
        //public const string UrlHrm = "http://localhost:5002";
        //public const string UrlUsm = "http://localhost:5005";
        //public const string UrlAdm = "https://adm-services-hypercube.sage.net.br";
        //public const string UrlHrm = "https://hrm-services-hypercube.sage.net.br";
        //public const string UrlUsm = "https://usm-services-hypercube.sage.net.br";
        public const string Token = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6WyI0MjBlMzBjNS05Y2VjLTRmMWEtYjk0Zi05M2VkNmM1MGQ5ZmYiLCI0MjBlMzBjNS05Y2VjLTRmMWEtYjk0Zi05M2VkNmM1MGQ5ZmYiXSwianRpIjoiZmU5MDdiOGJiNmE3NGEwZDg3YzVmOGM0NDJjNWU1MDgiLCJVc2VySWQiOiI0MjBlMzBjNS05Y2VjLTRmMWEtYjk0Zi05M2VkNmM1MGQ5ZmYiLCJTdWJzY3JpcHRpb25JZCI6IjQyNzFlZTQ3LTRmY2ItNGE4Yy1iYmVjLTljN2MyMGE5MTJjZCIsIlVzZXJOYW1lIjoiRGpvbmF0aGFuIiwiVXNlckVtYWlsIjoiZGpvbmF0aGFuLm1hc3Ryb2RpQHNhZ2UuY29tIiwiQ29nbml0b0FjY2Vzc1Rva2VuIjoiZXlKcmFXUWlPaUo0YVV4UmVqSTFURTVsY3pCMFNEVk9ZM0oxY1VoT2RqbENUM1JZV1VGc2VIbG9kRWM0Y0VKQ2JXVlJQU0lzSW1Gc1p5STZJbEpUTWpVMkluMC5leUp6ZFdJaU9pSXdZak01WVdOa01pMDJabUV6TFRSa1l6a3RZVFl6TUMwMU1qUXpNVGRsWWprellqa2lMQ0poZFdRaU9pSXhjR055T0daamEyNXVZMk5wTkRGemFUTnZORE5vYTJKeU5DSXNJbVZ0WVdsc1gzWmxjbWxtYVdWa0lqcG1ZV3h6WlN3aVpYWmxiblJmYVdRaU9pSTFaR1ptWlRCbVppMDBPV1JpTFRSaE1USXRPV1l4WlMwME1UZGpPVFU1WXprMU5EVWlMQ0owYjJ0bGJsOTFjMlVpT2lKcFpDSXNJbUYxZEdoZmRHbHRaU0k2TVRVM05USXlNalkzTnl3aWFYTnpJam9pYUhSMGNITTZYQzljTDJOdloyNXBkRzh0YVdSd0xuVnpMV1ZoYzNRdE1TNWhiV0Y2YjI1aGQzTXVZMjl0WEM5MWN5MWxZWE4wTFRGZlNUUnpWMFpUV2xoYUlpd2libUZ0WlNJNklrUnFiMjVoZEdoaGJpSXNJbU52WjI1cGRHODZkWE5sY201aGJXVWlPaUl3WWpNNVlXTmtNaTAyWm1FekxUUmtZemt0WVRZek1DMDFNalF6TVRkbFlqa3pZamtpTENKbGVIQWlPakUxTnpVeU1qWXlOemNzSW1saGRDSTZNVFUzTlRJeU1qWTNOeXdpWlcxaGFXd2lPaUprYW05dVlYUm9ZVzR1YldGemRISnZaR2xBYzJGblpTNWpiMjBpZlEuUTI3WnZybHNLVjdkdzJxOHEtekZ4OTZydzB3LWZkTEVUREU0c0xaVmgzakgxcmRWWlFTdVdwQVV6OHN2cF95Tl9YajdoY1FVb1IyUURtbGpXdFFLYzFrVUtFdUlPQUcwcGlTcHdvQlFndXJ3LVJRN0h2TVhnRDRUUGV6RTd4NFY2M25zbDg5U0w3Tk5KUzU3MGhCNDRzWm1PZjUwSThmLU9SekZZZVNVZlIwUEtFZG1oc2M3QURydk5YdWNDakpvMjBWZEJaZmJIa2lkRzR0YjdNMVBDWVBfUW16X3VMM0h2X2NaS2ZmYVNwVy1vVTVwVHdyRFVxQm5yUDU2akFMUFVJYi1fUW5WV2UySG43eXRkajVMMExQTklnaVpLaFpmRHk1ZE5TOGpQZWI1eU9CbHE5VVV0ZUs0T2JTNGRVNFZhU1ZvQXg0bVUydGFfS2xMSms1UUZRIiwibmJmIjoxNTc1MjIyNjc4LCJleHAiOjE1NzUyMjYyNzgsImlhdCI6MTU3NTIyMjY3OCwiaXNzIjoic2FnZS5ici5oeXBlcmN1YmUudXNtLnNlcnZpY2UiLCJhdWQiOiJzYWdlL2JyL2hd5cGVyY3ViZS9zZXJ2aWNlcyJ9.iGler2CfawaGk4zJqHyEn9OI3FhmEnyiFFdMoGWjr_U";
        public static string GetUrlAdm()
        {
            return UrlAdm;
        }
        public static string GetUrlHrm()
        {
            return UrlHrm;
        }

        public static string GetUrlUsm()
        {
            return UrlUsm;
        }

        public static string GetToken()
        {
            return Token;
        }
    }
}
