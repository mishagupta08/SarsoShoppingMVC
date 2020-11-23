using System.ServiceModel;

namespace SarsoBizServices
{
    // NOTE: If you change the interface name "IUtilities" here, you must also update the reference to "IUtilities" in Web.config.
    [ServiceContract]
    public interface IUtilities
    {
        [OperationContract]
        string AutoGenerateId();

        [OperationContract]
        string MoneyinWords(decimal v);

        [OperationContract]
        string Encrypt(string toEncrypt);

        [OperationContract]
        string Decrypt(string cipherString);

        [OperationContract]
        void SendErrorMail(string subject, string strBody);

        [OperationContract]
        void SendMail(string strMailTo, string subject, string strBody);

        [OperationContract]
        int SmsThroughGateWay(string mobiles, string message);

    }
}
