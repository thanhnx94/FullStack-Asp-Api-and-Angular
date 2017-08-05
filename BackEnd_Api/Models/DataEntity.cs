using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd_Api.Models
{
    public class DataEntity
    {
        private int _code;
        public string Status { get; set; }
        public int Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
                switch (this._code)
                {
                    case (int)DataCode.Ok:
                        this.Status = DataCode.Ok.ToString();
                        break;
                    case (int)DataCode.Created:
                        this.Status = DataCode.Created.ToString();
                        break;
                    case (int)DataCode.Accepted:
                        this.Status = DataCode.Accepted.ToString();
                        break;
                    case (int)DataCode.NoContent:
                        this.Status = DataCode.NoContent.ToString();
                        break;
                    case (int)DataCode.BadRequest:
                        this.Status = DataCode.BadRequest.ToString();
                        break;
                    case (int)DataCode.Unauthorized:
                        this.Status = DataCode.Unauthorized.ToString();
                        break;
                    case (int)DataCode.Forbidden:
                        this.Status = DataCode.Forbidden.ToString();
                        break;
                    case (int)DataCode.NotFound:
                        this.Status = DataCode.NotFound.ToString();
                        break;
                    case (int)DataCode.Conflict:
                        this.Status = DataCode.Conflict.ToString();
                        break;
                }
            }
        }

        public string Message { get; set; }
        public object Entity { get; set; }

        public int Total { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }

        public DataEntity()
        {
            this.Code = (int)DataCode.NoContent;
            this.Message = "";
            this.Entity = null;
        }

        public DataEntity(DataCode DataCode, string Message)
        {
            this.Code = (int)DataCode;
            this.Message = Message;
            this.Entity = null;
        }

        public DataEntity(DataCode DataCode, string Message, object Entity)
        {
            this.Code = (int)DataCode;
            this.Message = Message;
            this.Entity = Entity;
        }
        public DataEntity(DataCode DataCode, string Message, object Entity, int Total, int Skip, int Take)
        {
            this.Code = (int)DataCode;
            this.Message = Message;
            this.Entity = Entity;
            this.Total = Total;
            this.Skip = Skip;
            this.Take = Take;
        }
        public T GetEntity<T>()
        {
            string json = JsonConvert.SerializeObject(Entity);
            return JsonConvert.DeserializeObject<T>(json);
        }

        public enum DataCode
        {
            Ok = 200,
            Created = 201,
            Accepted = 202,
            NoContent = 204,
            BadRequest = 400,
            Unauthorized = 401,
            Forbidden = 403,
            NotFound = 404,
            Conflict = 409,
        }
    }
}