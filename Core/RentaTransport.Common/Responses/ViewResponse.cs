using RentaTransport.Common.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaTransport.Common.Responses
{
   public class ViewResponse
    {
        public ViewResponse()
        {
            IsSucceed = true;
            Description = UI.SuccessOperation;
        }

        public void Success()
        {
            IsSucceed = true;
            Description = UI.SuccessOperation;
        }

        public void Success(string description)
        {
            IsSucceed = true;
            Description = description;
        }

        public void Failure()
        {
            IsSucceed = false;
            Description = UI.FailureOperation;
        }

        public void Failure(string description)
        {
            IsSucceed = false;
            Description = description;
        }

        public ViewResponse Failure(string[] descriptions)
        {
            this.IsSucceed = false;
            this.Description = string.Join(", ", descriptions);
            return this;
        }

        public bool IsSucceed { get; set; }
        public string Description { get; set; }
    }
}
