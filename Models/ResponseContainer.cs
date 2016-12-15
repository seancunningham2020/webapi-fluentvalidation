using System.Collections.Generic;

namespace webapi_fluentvalidation.Models
{
    public class ResponseContainer
    {
        public List<string> Errors { get; set; }

        public object Result { get; set; }

        public ResponseContainer(object result, List<string> errors)
        {
            Errors = errors;
            Result = result;
        }
    }
}