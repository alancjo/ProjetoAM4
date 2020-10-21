using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjetoAM4.Enums;

namespace ProjetoAM4.Models
{
    [Table("Contacts")] // Nome da tabela no banco
    public class Contact
    {
        public int ContactId { get; set; }               // chave primária

        // Inicio Dados Pessoais
        [Required]
        [Display(Name = "Nome")]
        [StringLength(50)]
        public string Name { get; set; }                  // Nome

        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime Birth { get; set; }               // Data de Nascimento

        [Required(ErrorMessage = "Informe um CPF Válido")]
        public string CPF { get; set; }                   // CPF

        [Required]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }                // Email

        [Required]
        [DataType(DataType.PhoneNumber)]
        [MinLength(8)]
        [MaxLength(20)]
        [Display(Name = "Celular")]
        public string Telephone { get; set; }            // Número de telefone 

        // Início Endereço
        [Required]
        [DataType(DataType.PostalCode)]
        [MaxLength(10)]
        public string CEP { get; set; }                  // CEP

        [Required]
        [Display(Name = "Rua")]
        [StringLength(50)]
        public string Street { get; set; }               // RUA

        [Required]
        [Display(Name = "Número")]
        [MinLength(1)]
        public string HouseNumber { get; set; }         // falta adicionar no banco 

        [Display(Name = "Complemento")]
        [StringLength(50)]
        public string Complement { get; set; }          // Complemento

        [Required]
        [Display(Name = "Bairro")]
        [StringLength(30)]
        public string District { get; set; }             // Bairro

        [Required]
        [Display(Name = "Cidade")]
        [StringLength(30)]
        public string City { get; set; }                 // Cidade

        [Required]
        [Display(Name = "Estado")]
        public string State { get; set; }           // Estado

        // Início Mensagem
        [Required]
        [Display(Name = "Título/Motivo da Mensagem")]
        public TypeMotive MotiveMessage { get; set; }   // Tipo da Mensagem

        [Required]
        [DataType(DataType.Text)]
        [MinLength(20)]
        [MaxLength(1000)]
        [Display(Name = "Mensagem")]
        public string Message { get; set; }             // Mensagem

        // Campos não visíveis
        public DateTime RegistrationDate { get; set; }  // Data de Registro
        public DateTime? UpdateDate { get; set; }        // Data de atualização
        public bool Excluded { get; set; }              // Exclusão: Se falso, apresentar. Se verdadeiro, não apresentar
    }
}
