using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reduca.Api.Entity
{

    /// <summary>
    /// Entidade do documento Voluntario
    /// </summary>
    public class Voluntario
    {
        /// <summary>
        /// Id do voluntário.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do voluntário
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Data de nascimento do voluntário
        /// </summary>
        public DateTime DataNascimento { get; set; }

        /// <summary>
        /// RG do voluntário
        /// </summary>
        public string RG { get; set; }

        /// <summary>
        /// CPF do voluntário
        /// </summary>
        public string CPF { get; set; }

        /// <summary>
        /// Endereço do voluntário
        /// </summary>
        public string Endereco { get; set; }

        /// <summary>
        /// Numero do endereço do voluntário
        /// </summary>
        public int EnderecoNumero { get; set; }

        /// <summary>
        /// Cidade do voluntário
        /// </summary>
        public string Cidade { get; set; }

        /// <summary>
        /// Telefone do voluntário
        /// </summary>
        public string Telefone { get; set; }

        /// <summary>
        /// Email do voluntário
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Ocupacao do voluntário
        /// </summary>
        public string Ocupacao { get; set; }

        /// <summary>
        /// Formacao do voluntário
        /// </summary>
        public string Formacao { get; set; }

        /// <summary>
        /// Comentario sobre o cargo
        /// </summary>
        public string Comentario { get; set; }
    }
}
