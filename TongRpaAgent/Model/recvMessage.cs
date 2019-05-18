using System;
namespace mqAgent.Model
{
    public class RecvMessage
    {
        public string AgentId
        {
            get
            {
                return AgentId;
            }
        }

       // 요청유형 ( rest: restapi 실행 / exec: 스크립트실행 /  status: 상태체크 )
        public String ReqType
        {
            get
            {
                return ReqType;
            }
        }

        // 요청 데이타
        public String ReqMessage
        {
            get
            {
                return ReqMessage;
            }
        }
    }
}
