# II-Pract2

#### Ejercicio 1. Observaciones

  **a)** Cuando ninguno de los objetos es físico, no se aprecia nada, los objetos se mantienen estáticos y no interaccionan.
  
  **b)** En cambio, si le añadimos físicas a la esfera, podemos ver como esta si interacciona, por ejemplo, si la elevamos vemos como la gravedad actúa sobre ella, pero sigue sin interaccionar con el cubo.
  
  **c)** Seguidamente, al añadir físicas a ambos GameObjects, estos si interaccionan, por ejemplo, si la esfera se sitíua sobre el cubo, esta rebota al caer sobre este.
  
  **d)** Si aumentamos la masa de la esfera y repetimos el dejarla caer sobre el cubo, vemos como el cubo tiembla al colisionar con la esfera.
  
  **e)** Si hacemos que el cubo sea de tipo Is Trigger, entonces pierde sus físicas de colisión, por lo que la esfera atraviesa el cubo, aunque podemos ver cuando entra en primer contacto y cuando se mantiene en contacto por medio de OnTriggerEnter y OntriggerStay respectivamente.
  
  **f)** Si ahora hacemos que el cubo sea un rigidbody, entonces se escapa del plano, pues al no colisionar, lo atraviesa.
  
  **g)** Aparentemente, el cubo no reacciona, pues al ahberle congelado la rotación, este no puede temblar al recibir el impacto de la esfera.
  
  
#### Ejercicio 2. Observaciones

  **a)** Una vez añadimos un objeto a modo de personaje jugable, y le aplicamos el script, podemos desplazarlo por el terreno. Es necesario que añadamos en la transformación en el tranform del objeto la multiplicación por **Time.deltaTime**, ya que esta nos permite que se aplique de igual forma en todos los dispositivos, independientemente de los frames que sea capaz de renderizar por segundo.
  
  **b)** Al añadir el campo que permite graduar la velocidad podemos actualizarla desde el menú de control, lo que puede llegar a agilizar las pruebas o los testeos.
  
  **c)** También podemos añadir este campo de ejes virtuales, lo que permite permutar en función de las preferencias del usuario. Esto permite hacer una aproximación de lo que sería un menú que actualice los controles.
  
  
#### Ejercicio 3. Observaciones

  **a)** Las principales conclusiones que podemos extraer de este y todos los puntos es el poder trabajar con los collider y las funciones OnCollisionEnter, a su vez, podemos hacer una primera aproximación a mostrar información al usuario por pantalla.
  
  **b)** Además de trabajar con los collider, podemos hacer que estos actúen cuando el usuario realiza alguna acción en concreto como pulsar alguna tecla.
  
  **c)** Al igual que en el primer punto, aprendemos a trabajar con los collider y las fuerzas que actúan sobre los Rigidbody.
  
  **d)** A su vez, como en el ejercicio 2, practicamos como es añadir un objeto que el usuario puede manejar. Una pequeña aproximación a lo que sería un multijugador local en un videojuego.
  
  **e)** Finalmente, en el úñtimo punto, trabajamos con los identificadores de objetos por medio de tags, que nos permiten actuar de forma diferente según el objeto con el que interactúen.
