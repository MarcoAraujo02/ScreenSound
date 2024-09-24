using System.ComponentModel.DataAnnotations;

namespace ScreenSound.API.Requests;

// código omitido

public record MusicaRequest([Required] string nome, [Required] int ArtistaId, int anoLancamento, ICollection<GeneroRequest> Generos = null);