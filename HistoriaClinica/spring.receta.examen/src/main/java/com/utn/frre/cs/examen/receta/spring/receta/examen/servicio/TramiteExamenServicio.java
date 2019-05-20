package com.utn.frre.cs.examen.receta.spring.receta.examen.servicio;


import java.util.Optional;

import javax.validation.Valid;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.utn.frre.cs.examen.receta.spring.receta.examen.entidad.TramiteExamen;
import com.utn.frre.cs.examen.receta.spring.receta.examen.repositorio.TramiteExamenSpringDataRepositorio;

/**
 * RestController que implementa las operaciones basicas get,insert,delete,update para
 * <code>TramiteExamen</code>. cableo con TramiteExamenSpringDataRepositorio
 * para ayudarme a definir el comportamiento mas adecuado para esta clase
 * 
 * ("Conjunto de operaciones para Buscar, Crear, Actualizar y Eliminar TramiteExamen")
 * 
 * @author Gonza
 * @version 1.0
 */
@RestController
@RequestMapping("/api/examen/solicitud")
public class TramiteExamenServicio  {

	// Dependencies -----------------------------------------------------------

		@Autowired
		private TramiteExamenSpringDataRepositorio tramiteExamenRepositorio;

		// Operation --------------------------------------------------------------
		
		
		/**
		 * retorna una todas las TramiteExamen que tiene  la BD
		 * 
		 */
		@GetMapping()
		public Page<TramiteExamen> getPage(Pageable pageable) {
			return tramiteExamenRepositorio.findAll(pageable);
		}
		
		/**
		 * retorna un TramiteExamen segun su id
		 * 
		 */
		@GetMapping("/{id}")
		public ResponseEntity<TramiteExamen> findById(@PathVariable Long id) {
			Optional<TramiteExamen> opt = tramiteExamenRepositorio.findById(id);
			if (opt.isPresent())
				return ResponseEntity.ok(opt.get());
			return ResponseEntity.notFound().build();
		}
		
		/**
		 * crea un TramiteExamen 
		 * 
		 */
		@PostMapping()
		public ResponseEntity<TramiteExamen> create(@Valid @RequestBody TramiteExamen createRequest){
			return ResponseEntity.ok(tramiteExamenRepositorio.save(createRequest));
		}
		
		/**
		 * actualiza un TramiteExamen
		 * 
		 */
		
		@PutMapping()
		public ResponseEntity<TramiteExamen> update(@Valid @RequestBody TramiteExamen updateRequest) {
			boolean exists = tramiteExamenRepositorio.existsById(updateRequest.getIdeSolicitudExamen());
			if (exists) {
				return ResponseEntity.ok(tramiteExamenRepositorio.save(updateRequest));
			}
			return ResponseEntity.notFound().build();
		}
		
		/**
		 * borra un TramiteExamen segun un id 
		 * 
		 */
		@DeleteMapping("/{id}")
		public ResponseEntity<?> delete(@PathVariable Long id) {
			Optional<TramiteExamen> opt = tramiteExamenRepositorio.findById(id);
			if (opt.isPresent()) {
				tramiteExamenRepositorio.delete(opt.get());
				return ResponseEntity.ok().build();
			}
			return ResponseEntity.notFound().build();
		}
		
		
		
		
	}

