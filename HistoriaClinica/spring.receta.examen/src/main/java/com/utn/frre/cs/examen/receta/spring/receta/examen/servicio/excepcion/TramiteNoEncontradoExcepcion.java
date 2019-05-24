package com.utn.frre.cs.examen.receta.spring.receta.examen.servicio.excepcion;

import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.ResponseStatus;


//ejemplo simple: con @ResponseStatus(HttpStatus.UnaExcepcionAdecuada) puedo personalizar las excepciones generadas por mis recursos
@ResponseStatus(HttpStatus.NOT_FOUND)
public class TramiteNoEncontradoExcepcion extends RuntimeException {

	public TramiteNoEncontradoExcepcion(String message) {
		super(message);
		// TODO Auto-generated constructor stub
	}


	
	
	
}
