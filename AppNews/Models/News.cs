using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AppNews.Models
{
    //Fecha de Publicación
    //Título
    //Contenido(todo la noticia en particular debe permitir texto enriquecido (HTML))
    //Imagen(URL de la imagen)

    public class News
    {
        public int Id { get; set; }
        public DateTime Post { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
    }
}
