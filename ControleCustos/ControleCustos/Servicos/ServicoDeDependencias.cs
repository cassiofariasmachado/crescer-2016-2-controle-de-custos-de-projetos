﻿using ControleCustos.Dominio.UsuarioDominio.Classe;
using ControleCustos.Infraestrutura;
using ControleCustos.Repositorio.UsuarioRepositorio;

namespace ControleCustos.Servicos
{
    public class ServicoDeDependencias
    {
        public static UsuarioServico MontarUsuarioServico()
        {
            UsuarioServico usuarioServico =
                new UsuarioServico(
                    new UsuarioRepositorio(),
                    new ServicoDeCriptografia());

            return usuarioServico;
        }
    }
}