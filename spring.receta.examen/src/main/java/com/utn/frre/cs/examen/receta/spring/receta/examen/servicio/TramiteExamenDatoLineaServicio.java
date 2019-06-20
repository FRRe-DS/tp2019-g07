package com.utn.frre.cs.examen.receta.spring.receta.examen.servicio;

import java.util.Optional;
import java.util.Set;

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
import com.utn.frre.cs.examen.receta.spring.receta.examen.entidad.TramiteExamenDatoLinea;
import com.utn.frre.cs.examen.receta.spring.receta.examen.repositorio.TramiteExamenDatoLineaSpringDataRepositorio;

/**
 * ("Conjunto de operaciones para Buscar, Crear, Actualizar y Eliminar estudios solicitados")
 * 
 * RestController que implementa las operaciones basicas get,insert,delete,update para
 * <code>TramiteExamenDatoLineaServicio</code>. cableo con TramiteExamenDatoLineaSpringDataRepositorio
 * para ayudarme a definir el comportamiento mas adecuado para esta clase
 * 
 * 
 * 
 * @author Gonza
 * @version 1.0
 */
@RestController
@RequestMapping("/api/examen/estudioSolicitado")
public class TramiteExamenDatoLineaServicio {

	// Dependencias -----------------------------------------------------------

			@Autowired
			private TramiteExamenDatoLineaSpringDataRepositorio tramiteExamenDatoLineaRepositorio;

	// Operaciones --------------------------------------------------------------
			
			
			/**
			 * retorna una todas las TramiteExamenDatoLinea(estudios solicitados) que tiene  la BD
			 * 
			 */
			@GetMapping()
			public Page<TramiteExamenDatoLinea> getPage(Pageable pageable) {
				return tramiteExamenDatoLineaRepositorio.findAll(pageable);
			}
			
			/**
			 * retorna un  TramiteExamenDatoLinea (estudio particular) segun su id
			 * 
			 */
			@GetMapping("/{id}")
			public ResponseEntity<TramiteExamenDatoLinea> findById(@PathVariable Long id) {
				Optional<TramiteExamenDatoLinea> opt = tramiteExamenDatoLineaRepositorio.findById(id);
				if (opt.isPresent())
					return ResponseEntity.ok(opt.get());
				return ResponseEntity.notFound().build();
			}
			
			/**
			 * crea un  TramiteExamenDatoLinea (estudio particular)
			 * 
			 */
			@PostMapping()
			public ResponseEntity<TramiteExamenDatoLinea> create(@Valid @RequestBody TramiteExamenDatoLinea createRequest){
				return ResponseEntity.ok(tramiteExamenDatoLineaRepositorio.save(createRequest));
			}
			
			/**
			 * actualiza un  TramiteExamenDatoLinea (estudio particular)
			 * 
			 */
			
			@PutMapping()
			public ResponseEntity<TramiteExamenDatoLinea> update(@Valid @RequestBody TramiteExamenDatoLinea updateRequest) {
				boolean exists = tramiteExamenDatoLineaRepositorio.existsById(updateRequest.getIde_TramiteExamenDatoLinea());
				if (exists) {
					return ResponseEntity.ok(tramiteExamenDatoLineaRepositorio.save(updateRequest));
				}
				return ResponseEntity.notFound().build();
			}
			
			/**
			 * borra un  TramiteExamenDatoLinea (estudio particular) segun un id 
			 * 
			 */
			@DeleteMapping("/{id}")
			public ResponseEntity<?> delete(@PathVariable Long id) {
				Optional<TramiteExamenDatoLinea> opt = tramiteExamenDatoLineaRepositorio.findById(id);
				if (opt.isPresent()) {
					tramiteExamenDatoLineaRepositorio.delete(opt.get());
					return ResponseEntity.ok().build();
				}
				return ResponseEntity.notFound().build();
			}
			
			
			
			
			
			
		}
