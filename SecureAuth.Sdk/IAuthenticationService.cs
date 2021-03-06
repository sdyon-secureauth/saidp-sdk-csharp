﻿namespace SecureAuth.Sdk
{
    public interface IAuthenticationService
    {
        BaseResponse ValidateUserId(ValidateUserIdRequest request);
        BaseResponse ValidatePassword(ValidatePasswordRequest request);
        BaseResponse ValidateKba(ValidateKbaRequest request);
        BaseResponse ValidateOath(ValidateOathRequest request);
        BaseResponse ValidatePin(ValidatePinRequest request);
        BaseResponse ValidateOtp(ValidateOtpRequest request);
        SendOtpResponse SendEmailOtp(EmailOtpRequest request);
        SendOtpResponse SendEmailOtp(EmailOtpRequest request, SecureAuth.Sdk.Models.LanguageEnum en);
        SendOtpResponse SendHelpDeskOtp(HelpDeskOtpRequest request);
        SendOtpResponse SendPhonecallOtp(PhonecallOtpRequest request);
        SendOtpResponse SendPhonecallOtp(PhonecallOtpRequest request, SecureAuth.Sdk.Models.LanguageEnum en);
        SendOtpResponse SendPushOtp(PushOtpRequest request);
        SendOtpResponse SendSmsOtp(SmsOtpRequest request);
        SendOtpResponse SendSmsOtp(SmsOtpRequest request, SecureAuth.Sdk.Models.LanguageEnum en);
        PushAcceptResponse SendPushAccept(PushAcceptRequest request);
        BaseResponse GetPushAcceptStatus(string referenceId);
        SendOtpResponse SendAdHocSmsOtp(AdHocSmsOtpRequest request);
        SendOtpResponse SendAdHocSmsOtp(AdHocSmsOtpRequest request, SecureAuth.Sdk.Models.LanguageEnum en);
        SendOtpResponse SendAdHocPhonecallOtp(AdHocPhonecallOtpRequest request);
        SendOtpResponse SendAdHocPhonecallOtp(AdHocPhonecallOtpRequest request, SecureAuth.Sdk.Models.LanguageEnum en);
        SendOtpResponse SendAdHocEmailOtp(AdHocEmailOtpRequest request);
        SendOtpResponse SendAdHocEmailOtp(AdHocEmailOtpRequest request, SecureAuth.Sdk.Models.LanguageEnum en);
    }
}
