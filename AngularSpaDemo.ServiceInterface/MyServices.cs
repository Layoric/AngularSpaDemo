using System;
using ServiceStack;
using AngularSpaDemo.ServiceModel;

namespace AngularSpaDemo.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
