# AppNews

Aplicacion para ver Noticias:

El repositorio de la WEB API es el siguiente:

https://github.com/ukikalix/AppNews/tree/master/AppNews

PRE-REQUISITOS:
- Tener instalado Git para poder clonar los repositorios.

PASOS PARA EJECUTAR PROYECTO:

1.  Se deberán clonar los repositorios siguientes, ambos:
    - https://github.com/ukikalix/WebApiNews.git (API)
    - https://github.com/ukikalix/AppNews.git (Aplicacion)
  
2.  Abrir la solucion de la Web API, luego ir a la "Consola del Administrador de paquetes",
    ingresar el comando siguiente "update-database".

    (En el caso que aparezca un error, usar el comando "update-database -force".
    No es necesario cambiar la cadena de conexión, ni agregar datos a la BD.
    
3.   Por consiguiente ejecutar la aplicacion.
    
4.   Abrir la solucion de la Aplicacion de Noticias y para finalizar, ejecutar la misma, por consiguiente probar.
     No es necesario instalar plugins para extensiones .SCSS, ya estan renderizados los minificables de estilos.
     
     En la vista HOME se cargaran al azar 3 noticias, en la cual se podra ver una vista individual de la misma,
     o en total todas las noticias agregadas, con un buscador en el nav-bar, y filtro de busqueda por fecha
     en la vista de todas las noticias.
