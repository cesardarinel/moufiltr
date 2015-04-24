# moufiltr
El comportamiento estándar del controlador (driver) de un ratón (mouse) establece una correspondencia entre el desplazamiento del ratón y su puntero en una interface gráfica. En este proyecto, se debe crear un filtro para el controlador del ratón y lo convierta en uno "integrador". Una vez activado el filtro, éste debe establecer una correspondencia entre el desplazamiento del ratón y la velocidad de movimiento de su puntero en una interface gráfica de manera similar a como actúa el pedal del acelerador de un vehículo respecto a su velocidad. Este filtro podrá ser realizado como un driver o bien como un programa residente.

Esto significa que el mapping básico estándard es de la forma:

en tanto que en el solicitado, deberá ser:
Expresado de otra manera, el desplazamiento del ratón (en mickeys) significará cambio de velocidad en tanto que el del puntero del ratón sobre el display (pixels) significará cambio de espacio.

Se advierte que la descripción anterior es más sugestiva que precisa. Lo entregado sí debe precisar todo, sin ninguna ambigüedad.
