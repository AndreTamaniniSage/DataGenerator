using System;

namespace SAGE.BR.HyperCube.data.generator
{
    public static class ServiceConfig
    {
        //public const string UrlAdm = "http://ec2co-ecsel-nciy6l1hlzdi-72853533.us-east-1.elb.amazonaws.com:5001";
        //public const string UrlHrm = "http://ec2co-ecsel-nciy6l1hlzdi-72853533.us-east-1.elb.amazonaws.com:5002";
        //public const string UrlUsm = "http://ec2co-ecsel-nciy6l1hlzdi-72853533.us-east-1.elb.amazonaws.com:5005";

        //public const string UrlAdm = "http://localhost:5001";
        //public const string UrlHrm = "http://localhost:5002";
        //public const string UrlUsm = "http://localhost:5005";
        public const string UrlAdm = "https://adm-services-hypercube.sage.net.br";
        public const string UrlHrm = "https://hrm-services-hypercube.sage.net.br";
        public const string UrlUsm = "https://usm-services-hypercube.sage.net.br";
        public const string Token = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6WyIyMjczN2VkZS1kYTM1LTRhYmMtYjdjYy0wYTJmMTg5MDlmZDEiLCIyMjczN2VkZS1kYTM1LTRhYmMtYjdjYy0wYTJmMTg5MDlmZDEiXSwianRpIjoiYTVhMWVjNjVkZDcwNDUwZjg0NDIwOTAwNDA5YmRhYzMiLCJVc2VySWQiOiIyMjczN2VkZS1kYTM1LTRhYmMtYjdjYy0wYTJmMTg5MDlmZDEiLCJTdWJzY3JpcHRpb25JZCI6IjI3MjRjYmI2LWQ3YjMtNGRmOC1iMjQ3LTc2YTIwODYzZTJkYyIsIlVzZXJOYW1lIjoiSmVmZXJzb24gTWVuZGVzIExvcGVzIiwiVXNlckVtYWlsIjoiamVmZXJzb24ubG9wZXNAc2FnZS5jb20iLCJDb2duaXRvQWNjZXNzVG9rZW4iOiJleUpyYVdRaU9pSkZiVUpDVjNScmRURndZM3BGTjBaTFJVTnFWMGhVY1VadGJYSkZWVTVtZGtwaU4yVlVURkpPUW1wRlBTSXNJbUZzWnlJNklsSlRNalUySW4wLmV5SnpkV0lpT2lJNE1qUmpaRFk1TUMwd1pURXdMVFF5TUdVdE9HRTNOeTB5WW1Nd1l6SmxORFk1WmpNaUxDSmhkV1FpT2lJeU9XdGljakkxYlhOcmJXZHVPVE01YzNObmRUVXdPV2RxZFNJc0ltVnRZV2xzWDNabGNtbG1hV1ZrSWpwMGNuVmxMQ0psZG1WdWRGOXBaQ0k2SW1SaVl6SmlaREUwTFRRNU5qZ3RORE15TXkxaU1UYzBMVEU1TkRVM1lqTmtNRFpoTWlJc0luUnZhMlZ1WDNWelpTSTZJbWxrSWl3aVlYVjBhRjkwYVcxbElqb3hOVGN6T0RNd056STVMQ0pwYzNNaU9pSm9kSFJ3Y3pwY0wxd3ZZMjluYm1sMGJ5MXBaSEF1ZFhNdFpXRnpkQzB4TG1GdFlYcHZibUYzY3k1amIyMWNMM1Z6TFdWaGMzUXRNVjlNUVhaak1XRXdia0lpTENKdVlXMWxJam9pU21WbVpYSnpiMjRnVFdWdVpHVnpJRXh2Y0dWeklpd2lZMjluYm1sMGJ6cDFjMlZ5Ym1GdFpTSTZJamd5TkdOa05qa3dMVEJsTVRBdE5ESXdaUzA0WVRjM0xUSmlZekJqTW1VME5qbG1NeUlzSW1WNGNDSTZNVFUzTXpnek5ETXlPU3dpYVdGMElqb3hOVGN6T0RNd056STVMQ0psYldGcGJDSTZJbXBsWm1WeWMyOXVMbXh2Y0dWelFITmhaMlV1WTI5dEluMC5kMmdxYjZ4UTRzdVpkeUswbzJqQXM1N0VheFN3WnMwT1YtellFLXNtV0lZeHVTeDc1dGp3WnMwNzY1T3ZmdFBhUERuVGplVXh2WERUVy1Eb2Z6QWppNC1NNUYxSEFwV1EtRVM5dWRXYldtS3A2RkxqeUVTWDhZOVZxSkp6SGdQT01YamtWQkRyQWFXTThmaFMwTHN4anBTRnRhSjZiNXo5QUthblY2aVZwbjZ1Vmo2WXA4WlVlRWlYVnNkVi1xMWhuX09CRzhLYTRZUFQxM2xrejFfMHZydFdKRVlMUTNCZjJjSDU3ZlVtV1Vac0ozQUMwdFpxQnBmWklKM1RjeW9taWJUeEVSdnlMcTlSSG01bVdpLVVnN1R4TmZ4U011LWZzYUU2MnppUmk1X251QmllY3A5TXREQlJESHh2dC1NZDU5X0RZTTNlbk5YdEJZOVI3dDFvdHciLCJuYmYiOjE1NzM4MzA3MzEsImV4cCI6MTU3MzgzNDMzMSwiaWF0IjoxNTczODMwNzMxLCJpc3MiOiJzYWdlLmJyLmh5cGVyY3ViZS51c20uc2VydmljZSIsImF1ZCI6InNhZ2UvYnIvaHlwZXJjdWJlL3NlcnZpY2VzIn0.KkNEw30qLdQJ8Mfr098HKtgzcb60x0eocUqIOZNZcqE";
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
