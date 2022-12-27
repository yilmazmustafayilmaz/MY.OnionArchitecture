using Application.Services;
using AutoMapper;
using Domain.Dtos;
using MediatR;

namespace Application.Features.Users.Commands.CreateUser;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
{
    private readonly IUserService _userService;
    private readonly IMapper _mapper;

    public CreateUserCommandHandler(IUserService userService, IMapper mapper)
    {
        _userService = userService;
        _mapper = mapper;
    }

    public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
    {
        var userDto = _mapper.Map<CreateUserDto>(request);
        var added = await _userService.CreateAsync(userDto);
        var mapped = _mapper.Map<CreateUserCommandResponse>(added);
        return mapped;
    }
}
