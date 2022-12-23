using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Application.Features.Users.Commands.CreateUser;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
{
    private readonly UserManager<AppUser> _userManager;
    private readonly IMapper _mapper;

    public CreateUserCommandHandler(UserManager<AppUser> userManager, IMapper mapper)
    {
        _userManager = userManager;
        _mapper = mapper;
    }

    public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
    {
        var user = _mapper.Map<AppUser>(request);
        var added = await _userManager.CreateAsync(user, request.Password);
        var mapped = _mapper.Map<CreateUserCommandResponse>(added);

        if (added.Succeeded)
            mapped.Message = "Kullanıcı başarıyla oluşturuldu.";
        else
            foreach (var error in added.Errors)
                mapped.Message += $"{error.Code} - {error.Description}";

        return mapped;
    }
}
