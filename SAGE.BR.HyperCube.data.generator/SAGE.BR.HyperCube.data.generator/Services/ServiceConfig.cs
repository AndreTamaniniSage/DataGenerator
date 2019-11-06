using System;

namespace SAGE.BR.HyperCube.data.generator
{
    public static class ServiceConfig
    {
        //Chrome
        public const string UrlAdm = "http://localhost:5001";
        public const string UrlHrm = "http://localhost:5002";
        public const string UrlUsm = "http://localhost:5005";
        public const string Token = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6WyJmZTZhZWE4My04MDQ1LTRjM2QtYjg5NS0xNjE3MDQzNmQ5YTUiLCJmZTZhZWE4My04MDQ1LTRjM2QtYjg5NS0xNjE3MDQzNmQ5YTUiXSwianRpIjoiMDI3YmNkMzQxZjNkNDQzM2JhZDk3N2Q1ODcyMGZjOWIiLCJVc2VySWQiOiJmZTZhZWE4My04MDQ1LTRjM2QtYjg5NS0xNjE3MDQzNmQ5YTUiLCJTdWJzY3JpcHRpb25JZCI6IjM2YTI0MTJjLTMzMmItNDAyNS1iM2ZiLTAyNzc5ZDlmNWEzNiIsIlVzZXJOYW1lIjoiQW5kcsOpIFZpY3RvciBUYW1hbmluaSIsIlVzZXJFbWFpbCI6ImFuZHJlLnRhbWFuaW5pQHNhZ2UuY29tIiwiQ29nbml0b0FjY2Vzc1Rva2VuIjoiZXlKcmFXUWlPaUo0YVV4UmVqSTFURTVsY3pCMFNEVk9ZM0oxY1VoT2RqbENUM1JZV1VGc2VIbG9kRWM0Y0VKQ2JXVlJQU0lzSW1Gc1p5STZJbEpUTWpVMkluMC5leUp6ZFdJaU9pSmlPVFZpTjJGbE5pMHlaR0UwTFRSallUZ3RPVGc0TnkxbU0yVmhaV1E1WldReU5Ua2lMQ0poZFdRaU9pSXhjR055T0daamEyNXVZMk5wTkRGemFUTnZORE5vYTJKeU5DSXNJbVZ0WVdsc1gzWmxjbWxtYVdWa0lqcG1ZV3h6WlN3aVpYWmxiblJmYVdRaU9pSmxOems0WkdRd05DMDJaV1E1TFRSaU1HUXRPV05tWVMxbU9EQXlOR1JoT0RreFpESWlMQ0owYjJ0bGJsOTFjMlVpT2lKcFpDSXNJbUYxZEdoZmRHbHRaU0k2TVRVM01qazNOamcyTWl3aWFYTnpJam9pYUhSMGNITTZYQzljTDJOdloyNXBkRzh0YVdSd0xuVnpMV1ZoYzNRdE1TNWhiV0Y2YjI1aGQzTXVZMjl0WEM5MWN5MWxZWE4wTFRGZlNUUnpWMFpUV2xoYUlpd2libUZ0WlNJNklrRnVaSExEcVNCV2FXTjBiM0lnVkdGdFlXNXBibWtpTENKamIyZHVhWFJ2T25WelpYSnVZVzFsSWpvaVlqazFZamRoWlRZdE1tUmhOQzAwWTJFNExUazRPRGN0WmpObFlXVmtPV1ZrTWpVNUlpd2laWGh3SWpveE5UY3lPVGd3TkRZeUxDSnBZWFFpT2pFMU56STVOelk0TmpJc0ltVnRZV2xzSWpvaVlXNWtjbVV1ZEdGdFlXNXBibWxBYzJGblpTNWpiMjBpZlEuWHRCTy0zSnZ6Qzg3MlhPSEY0N3NBZkJRYkFPVnk5Y055THkxaGg5SHVEQTBjUjhVVE5JV0RDdEx2V25XMkwybXFvMHNXUWxlUGlUMlRKRHBOTmJzd3JUOEZXOXhqcVpkTUFRMTlLTTBBSFZCQ3FRbzN3bVphcVVPMVhtUVB0OVpSMjFGRUtZemNqeVNkWUxOTm1ubWJsek5KX2VIME1LN193ZXNXQnBmX3dDVEZqLUJHZ3d4YVpXUEFVTmVvVWhoa1F5YThmU3lFSnJFR0tmVUFTckZaaGxodE94UVBzRE5zSGlVc2FqZlZsNWdOUm1kRjl1cEVSRzZ3UE5qc0Ixb042ckx3cTdtaDFESHNFNGxBM0VUdm1qVzlCZlFSNkNYSkFXcTQzZENIWkR5cEJBRldqUE5ZcWpvSHVpR1FqRk56Z01QUFEyd1JKNzdmNlZNcFZfVWxRIiwibmJmIjoxNTcyOTc2ODYzLCJleHAiOjE1NzI5ODA0NjMsImlhdCI6MTU3Mjk3Njg2MywiaXNzIjoic2FnZS5ici5oeXBlcmN1YmUudXNtLnNlcnZpY2UiLCJhdWQiOiJzYWdlL2JyL2h5cGVyY3ViZS9zZXJ2aWNlcyJ9.gaNzJItESA16jydQNlxUkoiEWYZb-hFHA8PZDOzuaG8";
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
