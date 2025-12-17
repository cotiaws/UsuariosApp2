using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosApp.Domain.Dtos
{
    /// <summary>
    /// DTO para a requisição de autenticação de usuário.
    /// </summary>
    public record AutenticarRequest(
            string email, //email do usuário
            string senha  //senha do usuário
        );
}
