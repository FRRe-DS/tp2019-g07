package com.utn.frre.cs.examen.receta.spring.receta.examen.servicio;


import java.net.URI;
import java.util.List;
import java.util.Optional;
import java.util.Set;

import javax.validation.Valid;

import org.apache.catalina.User;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.web.servlet.ServletComponentScan;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.servlet.support.ServletUriComponentsBuilder;

import com.utn.frre.cs.examen.receta.spring.receta.examen.entidad.TramiteExamen;
import com.utn.frre.cs.examen.receta.spring.receta.examen.entidad.TramiteExamenDatoLinea;
import com.utn.frre.cs.examen.receta.spring.receta.examen.repositorio.TramiteExamenDatoLineaSpringDataRepositorio;
import com.utn.frre.cs.examen.receta.spring.receta.examen.repositorio.TramiteExamenSpringDataRepositorio;
import com.utn.frre.cs.examen.receta.spring.receta.examen.servicio.excepcion.TramiteNoEncontradoExcepcion;

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
@CrossOrigin(origins="http://localhost:4200")
@RequestMapping("/api/examen/solicitud")
public class TramiteExamenServicio  {

	// Dependencies -----------------------------------------------------------

		@Autowired
		private TramiteExamenSpringDataRepositorio tramiteExamenRepositorio;

		@Autowired
		private TramiteExamenDatoLineaSpringDataRepositorio tramiteExamenDatoLineaRepositorio;
		
		// Operation --------------------------------------------------------------
		
		
		/**
		 * retorna una todas las TramiteExamen que tiene  la BD
		 * 
		 */
		@GetMapping()
		public List<TramiteExamen> getPage(Pageable pageable) {
			return tramiteExamenRepositorio.findAll();
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
		
		
		/**
		 * retorna  los estudios asociados a partir de un TramiteExamen
		 *  
		 * 
		 */
		@GetMapping("/{id}/estudiosSolicitados")
		public Set<TramiteExamenDatoLinea> recuperarEstudios(@PathVariable Long id)  {
			Optional<TramiteExamen> opt = tramiteExamenRepositorio.findById(id);
			if (!opt.isPresent()) {
				throw new TramiteNoEncontradoExcepcion("id-" + id); //seguir mirando este tema para tirar una linda excepcion al menos
			}
			return  opt.get().getTramiteExamenDatoLineas();  
		}
		
		/**
		 * 
		 * A partir de un TramiteExamen crea un estudio solicitado
		 *  
		 */
		
		@PostMapping("/{id}/nuevoEstudioSolicitado")
		public ResponseEntity<Object> createEstudioSolicitado(@PathVariable Long id,@Valid @RequestBody TramiteExamenDatoLinea tramiteExamenDatoLinea) {
			 
			Optional<TramiteExamen> opt = tramiteExamenRepositorio.findById(id);
			
			if (!opt.isPresent()) {
				return ResponseEntity.notFound().build();  
			}
			
			TramiteExamen tramiteExamen = opt.get();
			
			tramiteExamenDatoLinea.setTramiteExamen(tramiteExamen);
			
			tramiteExamenDatoLineaRepositorio.save(tramiteExamenDatoLinea);
			
			URI location = ServletUriComponentsBuilder.fromCurrentRequest().path("/{id}/nuevoEstudioSolicitado").buildAndExpand(tramiteExamenDatoLinea.getIde_TramiteExamenDatoLinea()).toUri();
			
			return ResponseEntity.created(location).build();
		}
		
		
	
		
	}

