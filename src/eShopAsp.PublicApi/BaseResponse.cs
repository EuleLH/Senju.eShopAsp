namespace eShopAsp.PublicApi;

public abstract class BaseResponse : BaseMessage
{
    public BaseResponse(Guid correlationId) : base() => base._correlationId = correlationId;
    public BaseResponse(){}
}