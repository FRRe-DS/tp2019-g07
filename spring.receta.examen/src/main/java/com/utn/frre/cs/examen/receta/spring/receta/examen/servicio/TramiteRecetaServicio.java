package com.utn.frre.cs.examen.receta.spring.receta.examen.servicio;

import java.util.List;
import java.util.Optional;
import java.util.stream.Collectors;

import javax.validation.Valid;

import org.springframework.beans.factory.annotation.Autowired;
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

import com.utn.frre.cs.examen.receta.spring.receta.examen.entidad.TramiteExamen;
import com.utn.frre.cs.examen.receta.spring.receta.examen.entidad.TramiteReceta;
import com.utn.frre.cs.examen.receta.spring.receta.examen.repositorio.TramiteRecetaSpringDataRepositorio;

/**
 * RestController que implementa las operaciones basicas get,insert,delete,update para
 * <code>TramiteReceta</code>. cableo con TramiteRecetaSpringDataRepositorio
 * para ayudarme a definir el comportamiento mas adecuado para esta clase
 * 
 * ("Conjunto de operaciones para Buscar, Crear, Actualizar y Eliminar TramiteReceta")
 * 
 * @author Gonza
 * @version 1.0
 */
@RestController
@CrossOrigin(origins= "*")
@RequestMapping("/api/examen/informacionReceta")
public class TramiteRecetaServicio  {

	// Dependencies -----------------------------------------------------------

			@Autowired
			private TramiteRecetaSpringDataRepositorio tramiteRecetaRepositorio;

			// Operation --------------------------------------------------------------
			

			/**
			 * retorna una todas las TramiteReceta que tiene  la BD
			 * 
			 */
			@GetMapping()
			public Page<TramiteReceta> getPage(Pageable pageable) {
				return tramiteRecetaRepositorio.findAll(pageable);
			}
			
			/**
			 * retorna un TramiteReceta segun su id
			 * 
			 */
			@GetMapping("/{id}")
			public ResponseEntity<TramiteReceta> findById(@PathVariable Long id) {
				Optional<TramiteReceta> opt = tramiteRecetaRepositorio.findById(id);
				if (opt.isPresent())
					return ResponseEntity.ok(opt.get());
				return ResponseEntity.notFound().build();
			}
			
			/**
			 * crea un TramiteReceta 
			 * 
			 */
			@PostMapping()
			public ResponseEntity<TramiteReceta> create(@Valid @RequestBody TramiteReceta createRequest){
				return ResponseEntity.ok(tramiteRecetaRepositorio.save(createRequest));
			}
			
			/**
			 * actualiza un TramiteReceta
			 * 
			 */
			
			@PutMapping()
			public ResponseEntity<TramiteReceta> update(@Valid @RequestBody TramiteReceta updateRequest) {
				boolean exists = tramiteRecetaRepositorio.existsById(updateRequest.getIde_receta());
				if (exists) {
					return ResponseEntity.ok(tramiteRecetaRepositorio.save(updateRequest));
				}
				return ResponseEntity.notFound().build();
			}
			
			/**
			 * borra un TramiteReceta segun un id 
			 * 
			 */
			@DeleteMapping("/{id}")
			public ResponseEntity<?> delete(@PathVariable Long id) {
				Optional<TramiteReceta> opt = tramiteRecetaRepositorio.findById(id);
				if (opt.isPresent()) {
					tramiteRecetaRepositorio.delete(opt.get());
					return ResponseEntity.ok().build();
				}
				return ResponseEntity.notFound().build();
			}
			
			
			/**
			 * retorna los  TramiteExamen correspondientes a un medico segun su id
			 * 
			 */
			@GetMapping("/medico/{id}")
			public List<TramiteReceta> getTramiteRecetaMedico(@PathVariable int id) {
				List<TramiteReceta> misTramites = tramiteRecetaRepositorio.findAll();
				List<TramiteReceta> misTramitesMed = misTramites.stream()
						.filter(x -> x.getIde_personal_med() == id)
						.collect(Collectors.toList());
				return misTramitesMed;
			}
			
		}