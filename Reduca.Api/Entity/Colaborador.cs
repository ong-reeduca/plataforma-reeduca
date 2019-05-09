
using System;

namespace Reduca.Api.Entity
{
    /// <summary>
    /// Entidade do documento Colaborador
    /// </summary>
    public class Colaborador
    {
        /// <summary>
        /// Id do colaborador.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do colaborador.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Data de nascimento do colaborador
        /// </summary>
        public DateTime DataNascimento { get; set; }

        /// <summary>
        /// RG do colaborador
        /// </summary>
        public string RG { get; set; }

        /// <summary>
        /// CPF do colaborador
        /// </summary>
        public string CPF { get; set; }

        /// <summary>
        /// Endereço do colaborador
        /// </summary>
        public string Endereco { get; set; }

        /// <summary>
        /// Numero do endereço do colaborador
        /// </summary>
        public int EnderecoNumero { get; set; }

        /// <summary>
        /// Cidade do colaborador
        /// </summary>
        public string Cidade { get; set; }

        /// <summary>
        /// Telefone do colaborador
        /// </summary>
        public string Telefone { get; set; }

        /// <summary>
        /// Email do colaborador
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Ocupacao do colaborador
        /// </summary>
        public string Ocupacao { get; set; }

        /// <summary>
        /// Formacao do colaborador
        /// </summary>
        public string Formacao { get; set; }

        /// <summary>
        /// Comentario sobre o cargo (ensino)
        /// </summary>
        public string Comentario { get; set; }

        /// <summary>
        /// Carga horária semanal
        /// </summary>
        public int CargaHoraria { get; set; }
    }
}
