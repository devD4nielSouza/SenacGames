using System;
using System.Collections.Generic;
using System.Text;


// DTO: Data Trasnfer Object
//1. Segurança: evita expor dados internos do banco
//2. Flexibilidade: permitite enviar apenas os campos necessarios
//3. Desacoplamento: a API nao depende da estrutura do banco.
namespace SenacGames.Application.DTOs
{
    public class GameDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ReleaseYear { get; set; }
        public string CoverImageUrl { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public bool IsFeatured { get; set; }
        public DateTime CreatedAt { get; set; }
    }
    public class CreateGameDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int RealeaseYear { get; set; }
        public string CoverImageUrl { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public bool IsFeatured { get; set; }
    }
    public class UpdateGameDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; }= string.Empty;
        public int ReleaseYear { get; set; }
        public string CoverImageUrl { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public bool IsFeatuerd { get; set; }

    }

}
