using System;

namespace GlobalNET.Classes {

    public class ServerSetting {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Active { get; set; }
    }

    /// <summary>
    /// Server Configuration definition for Backend API  EASYDATACenter
    /// </summary>
    public enum ServerSettingKeys {
        ApiPort,
        ServiceEmail,
        SMTPServer,
        SMTPPort,
        SMTPUserName,
        SMTPPassword,
        LoginTimeoutMinutes,
        TimeTokenValidation,
        SocketTimeoutMinutes,
        MaxSocketBufferSizeKb,
        HttpsProtocol,
        CertificateDomain,
        CertificatePassword,
        JwtLocalKey,
        InternalCachingEnabled,
        LoggingCacheTimeMinutes,
        EnableApiDescription,
        EnableDataManager,
        EnableServerHealthService,
        UseDBLocalAutoupdatedDials
    }
}