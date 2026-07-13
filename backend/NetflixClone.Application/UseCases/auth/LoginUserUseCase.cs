public LoginResponse Execute(LoginRequest request)
{
     // procura usuário

    // verifica senha

    // cria as claims

    var claims = new[]
    {
        new Claim(ClaimTypes.Name, user.Email)
        new Claim(ClaimTypes.Role, user.Role)
    };


    // cria o JWT

    // retorna
}