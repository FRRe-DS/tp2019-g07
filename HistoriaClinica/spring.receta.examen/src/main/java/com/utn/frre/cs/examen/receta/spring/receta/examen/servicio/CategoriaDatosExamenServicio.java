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


import com.utn.frre.cs.examen.receta.spring.receta.examen.entidad.CategoriaDatosExamen;
import com.utn.frre.cs.examen.receta.spring.receta.examen.repositorio.CategoriaDatosExamenSpringDataRepositorio;

/**
 * RestController que implementa las operaciones basicas get,insert,delete,update para
 * <code>CategoriaDatosExamen</code>. cableo con CategoriaDatosExamenSpringDataRepositorio
 * para ayudarme a definir el comportamiento mas adecuado para esta clase
 * 
 * ("Conjunto de operaciones para Buscar, Crear, Actualizar y Eliminar tipos de Examenes")
 * 
 * @author Gonza
 * @version 1.0
 */
@RestController
@RequestMapping("/api/examen/tipoExamen")
public class CategoriaDatosExamenServicio  {

	// Dependencies -----------------------------------------------------------

		@Autowired
		private CategoriaDatosExamenSpringDataRepositorio categoriaDatosExamenRepositorio;

		// Operation --------------------------------------------------------------
		
		/**
		 * retorna una todas las categoriaDatosexamen (estudios) que tiene   la BD
		 * 
		 */
		
		@GetMapping()
		public Page<CategoriaDatosExamen> getPage(Pageable pageable) {
			return categoriaDatosExamenRepositorio.findAll(pageable);
		}
		
		/**
		 * retorna una categoria de examen segun su id
		 * 
		 */
		@GetMapping("/{id}")
		public ResponseEntity<CategoriaDatosExamen> findById(@PathVariable Long id) {
			Optional<CategoriaDatosExamen> opt = categoriaDatosExamenRepositorio.findById(id);
			if (opt.isPresent())
				return ResponseEntity.ok(opt.get());
			return ResponseEntity.notFound().build();
		}
		
		/**
		 * crea una categoria de examen 
		 * 
		 */
		@PostMapping()
		public ResponseEntity<CategoriaDatosExamen> create(@Valid @RequestBody CategoriaDatosExamen createRequest){
			return ResponseEntity.ok(categoriaDatosExamenRepositorio.save(createRequest));
		}
		
		/**
		 * actualiza una categoria de examen 
		 * 
		 */
		
		@PutMapping()
		public ResponseEntity<CategoriaDatosExamen> update(@Valid @RequestBody CategoriaDatosExamen updateRequest) {
			boolean exists = categoriaDatosExamenRepositorio.existsById(updateRequest.getCod_dato());
			if (exists) {
				return ResponseEntity.ok(categoriaDatosExamenRepositorio.save(updateRequest));
			}
			return ResponseEntity.notFound().build();
		}
		
		/**
		 * borra una categoria de examen segun un id 
		 * 
		 */
		@DeleteMapping("/{id}")
		public ResponseEntity<?> delete(@PathVariable Long id) {
			Optional<CategoriaDatosExamen> opt = categoriaDatosExamenRepositorio.findById(id);
			if (opt.isPresent()) {
				categoriaDatosExamenRepositorio.delete(opt.get());
				return ResponseEntity.ok().build();
			}
			return ResponseEntity.notFound().build();
		}
		
		
		
		
	}
