using MediatR;
using TS.Result;

namespace ERPServer.Application.Features.Auth.Login
{
    //hem mail hem username ile giriş yapabilmek için requeste istekte bulunan method
    public sealed record LoginCommand(
        string EmailOrUserName,
        string Password) : IRequest<Result<LoginCommandResponse>>;
}
