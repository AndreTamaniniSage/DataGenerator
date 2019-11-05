using System;

namespace SAGE.BR.HyperCube.data.generator
{
    public static class ServiceConfig
    {
        //Chrome
        public const string UrlAdm = "http://ec2co-ecsel-nciy6l1hlzdi-72853533.us-east-1.elb.amazonaws.com:5001";
        public const string UrlHrm = "http://ec2co-ecsel-nciy6l1hlzdi-72853533.us-east-1.elb.amazonaws.com:5002";
        public const string UrlUsm = "http://ec2co-ecsel-nciy6l1hlzdi-72853533.us-east-1.elb.amazonaws.com:5005";
        public const string Token = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6WyJmZTZhZWE4My04MDQ1LTRjM2QtYjg5NS0xNjE3MDQzNmQ5YTUiLCJmZTZhZWE4My04MDQ1LTRjM2QtYjg5NS0xNjE3MDQzNmQ5YTUiXSwianRpIjoiNzRhOWM2MDc4ZjhhNDEwZDk1NWZmZDdjOTJjZjJiODgiLCJVc2VySWQiOiJmZTZhZWE4My04MDQ1LTRjM2QtYjg5NS0xNjE3MDQzNmQ5YTUiLCJTdWJzY3JpcHRpb25JZCI6IjUzMmY5MTQ0LWJiMmItNDZjNi1hYTZiLTcyMGZiM2RlZDQwZiIsIlVzZXJOYW1lIjoiQW5kcsOpIFZpY3RvciBUYW1hbmluaSIsIlVzZXJFbWFpbCI6ImFuZHJlLnRhbWFuaW5pQHNhZ2UuY29tIiwiQ29nbml0b0FjY2Vzc1Rva2VuIjoiZXlKcmFXUWlPaUo0YVV4UmVqSTFURTVsY3pCMFNEVk9ZM0oxY1VoT2RqbENUM1JZV1VGc2VIbG9kRWM0Y0VKQ2JXVlJQU0lzSW1Gc1p5STZJbEpUTWpVMkluMC5leUp6ZFdJaU9pSmlPVFZpTjJGbE5pMHlaR0UwTFRSallUZ3RPVGc0TnkxbU0yVmhaV1E1WldReU5Ua2lMQ0poZFdRaU9pSXhjR055T0daamEyNXVZMk5wTkRGemFUTnZORE5vYTJKeU5DSXNJbVZ0WVdsc1gzWmxjbWxtYVdWa0lqcG1ZV3h6WlN3aVpYWmxiblJmYVdRaU9pSTJNV0U1T0RobU5pMDJabVV3TFRRNE1UQXRZalEyTkMxa1lXRTBPVGhqT0dNek1qUWlMQ0owYjJ0bGJsOTFjMlVpT2lKcFpDSXNJbUYxZEdoZmRHbHRaU0k2TVRVM01qazNNalkxTnl3aWFYTnpJam9pYUhSMGNITTZYQzljTDJOdloyNXBkRzh0YVdSd0xuVnpMV1ZoYzNRdE1TNWhiV0Y2YjI1aGQzTXVZMjl0WEM5MWN5MWxZWE4wTFRGZlNUUnpWMFpUV2xoYUlpd2libUZ0WlNJNklrRnVaSExEcVNCV2FXTjBiM0lnVkdGdFlXNXBibWtpTENKamIyZHVhWFJ2T25WelpYSnVZVzFsSWpvaVlqazFZamRoWlRZdE1tUmhOQzAwWTJFNExUazRPRGN0WmpObFlXVmtPV1ZrTWpVNUlpd2laWGh3SWpveE5UY3lPVGMyTWpVM0xDSnBZWFFpT2pFMU56STVOekkyTlRjc0ltVnRZV2xzSWpvaVlXNWtjbVV1ZEdGdFlXNXBibWxBYzJGblpTNWpiMjBpZlEuSGxOLVF2MkZvdHZ2NUdHZ29oWVljanV3ZVhXMVYwZ3RCZm51QkFHRmw3WldWWFpnQnpacDhnbExTSl9NdzhvYUxUR0RDaE1ObTFVeXczYTh1ekpCUVVYd3VGRkxOVlZIYTRvNWY2bGxsRERpcXN6UFBUNXlHTFBaOWd2cENJOTc1VVpvZmtnQlhXOGhqRktDQ2NMQ2pMMmU1UnBYTzF2c3BEcUZaZy1pdGg2Rnd5MDcwNVJJUms1TUlERzg0Zk5RbU9VaV9lTUZHQ29VRWc1MU1lVlFCTFBFMmJXTW1lS0xyZldzeTFYdl9KQXVQc1d3VHdGX3BmeC1WejNZZUdKbWlUbUQ0WWUwMTRyNC1rR1lMUDJ3UkM2aDQyZTgyeEozWTVnUUJ4TDZFUnBOcTlyNEFDdGJES0FuNUczYW5DU1JyMWNkUWVMMTBhRlROWTA1SjdsMmVnIiwibmJmIjoxNTcyOTcyNjU4LCJleHAiOjE1NzI5NzYyNTgsImlhdCI6MTU3Mjk3MjY1OCwiaXNzIjoic2FnZS5ici5oeXBlcmN1YmUudXNtLnNlcnZpY2UiLCJhdWQiOiJzYWdlL2JyL2h5cGVyY3ViZS9zZXJ2aWNlcyJ9.NxXQHdI1cdTRtrXsQRdCci82wjXMVtGtsib5TnyDV4w";
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
