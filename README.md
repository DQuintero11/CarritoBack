El proyecto en cuanto a front se ejecuta en la url http://localhost:3000/
en cuanto a back, abre el swagger en la url https://localhost:7056/swagger/index.html

la solucion fue realizada en react para front, en la cual se realizo lo siguiente:
* modificar el app.js , en el render mostrar el listado de productos obtenidos llamando el back, cada item tiene un boton con el texto "Agregar al carrito" en el cual al darle click va al back
  y lo agrega a una lista temporal estatica asi mismo hace una especie de recarga y consume el back de obtener carrito para ver el nuevo item agregado al carrito
  tambien esta la funcion para obtener la combinacion de productos mas adecuada segun el presupuesto , la cual se invoca al darle click al boton "encontrar combinacion", asi mismo se realiza un css para darle estilo a la pagina


en cuanto al back:
* hay dos controladores, uno llamado productos en el cual estan los productos estaticos con los 4 items establecidos en el pdf, asi mismo esta el controlador carrito el cual agrega y obtiene los items productos}
  agregados al producto, en las siguientes urls se pueden invocar
  [get]https://localhost:7056/api/Products
  [get]https://localhost:7056/api/Carrito
  [set]https://localhost:7056/api/Carrito

  

