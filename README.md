# Sobre el proyecto

Este software fue realizado por Florencia Perea, Gonzalo Gimenez e Irina Ponzi en el marco de la materia 
Desarrollo de sistemas orientados a objetos, de la carrera Desarrollo de Software en el IFTS N° 11

* Fue desarrollado en .NET 6 (Windows Forms .NET). 

* Para la generación de archivos PDF incorpora la biblioteca `iTextSharp v.5.5.13.3`.
  Información sobre la versión y documentación en: https://kb.itextpdf.com/home/it5kb/releases/release-itext-5-5-13-3

* Para el manejo de contraseñas de forma segura se utilizó la biblioteca `System.Security.Cryptography` proporcionada por .NET 6.
  Documentación en: https://learn.microsoft.com/es-es/dotnet/standard/security/ensuring-data-integrity-with-hash-codes

* En la carpeta `Recursos` se puede encontrar la clase `Datos` que es utilizada a modo de simulación de una base de datos. 

# Utilización del software

El software sirve para gestionar pedidos de comidas. Está pensado para ser utilizado por los empleados en locales de comidas rápidas.
Cuenta con un Log in donde cada empleado deberá ingresar su usuario y contraseña para poder ingresar. Una vez validado, el empleado
tendrá acceso a la pantalla donde se gestiona la toma de pedidos de los clientes. Al finalizar cada transacción, el sistema genera un
ticket en PDF con el detalle del pedido.

El programa incluye dentro del proyecto todos los recusos necesarios para su funcionamiento.


* Usuarios y contraseñas para ingresar al sistema:

  Usuario: PAvellaneda
  Password: Prueba777

  Usuario: FPerea
  Password: Prueba123

  Usuario: GGimenez
  Password: Prueba456

  Usuario: IPonzi
  Password: Prueba789

