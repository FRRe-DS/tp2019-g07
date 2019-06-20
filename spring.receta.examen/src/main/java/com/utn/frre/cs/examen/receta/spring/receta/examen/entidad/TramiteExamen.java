package com.utn.frre.cs.examen.receta.spring.receta.examen.entidad;

import java.util.Date;
import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonIgnore;

/**
 * TramiteExamen: Representa el tramite que un medico hace de una Categoria
 * particular de examen para una   internacion particular
 * 
 * @author Gonza
 * @version 1.0
 */
@Entity
@Table(name = "Tramite_Examen")
public class TramiteExamen {

	/**
	 * Es el id que identifica un Tramite de examen que inicio un medico de una
	 * Categoria particular de examen
	 */

	@Id
	@GeneratedValue
	@Column(name = "IDE_SOLICITUD_EXAMEN")
	private Long ideSolicitudExamen;


	/**
	 * Representa el id que identifica al medico que inicio este tramite
	 */
	private int idePersonalMed;

	/**
	 * Representa la fecha en que se solicito este examen
	 */
	private Date fecExamen;

	
	/**
	 * Es la internacion donde se registrara este tramite de examen
	 */
	
	private int id_internacion;
	
	/**
	 * Representa que un tramite puede tener multiples estudios solicitados 
	 * 
	 */
	@JsonIgnore
	@OneToMany(mappedBy = "tramiteExamen")
	private Set<TramiteExamenDatoLinea> tramiteExamenDatoLineas;

	/**
	 * Constructor por defecto de la clase TramiteExamen
	 */

	public TramiteExamen() {

	}

	/**
	 * Constructor  de la clase TramiteExamen para hacer un update particular
	 */
	
	public TramiteExamen(Long ideSolicitudExamen, CategoriaExamen categoriaExamen, int idePersonalMed, Date fecExamen,
			int id_internacion, Set<TramiteExamenDatoLinea> tramiteExamenDatoLineas) {
		super();
		this.ideSolicitudExamen = ideSolicitudExamen;
		this.idePersonalMed = idePersonalMed;
		this.fecExamen = fecExamen;
		this.id_internacion = id_internacion;
		this.tramiteExamenDatoLineas = tramiteExamenDatoLineas;
	}

	
	/**
	 * Constructor  de la clase TramiteExamen para hacer un insert particular
	 */
	public TramiteExamen(CategoriaExamen categoriaExamen, int idePersonalMed, Date fecExamen, int id_internacion,
			Set<TramiteExamenDatoLinea> tramiteExamenDatoLineas) {
		super();
		this.idePersonalMed = idePersonalMed;
		this.fecExamen = fecExamen;
		this.id_internacion = id_internacion;
		this.tramiteExamenDatoLineas = tramiteExamenDatoLineas;
	}

	//Getters y Setters-----------------------------------------
	
	
	public Long getIdeSolicitudExamen() {
		return ideSolicitudExamen;
	}

	public void setIdeSolicitudExamen(Long ideSolicitudExamen) {
		this.ideSolicitudExamen = ideSolicitudExamen;
	}


	public int getIdePersonalMed() {
		return idePersonalMed;
	}

	public void setIdePersonalMed(int idePersonalMed) {
		this.idePersonalMed = idePersonalMed;
	}

	public Date getFecExamen() {
		return fecExamen;
	}

	public void setFecExamen(Date fecExamen) {
		this.fecExamen = fecExamen;
	}

	

	public int getId_internacion() {
		return id_internacion;
	}

	public void setId_internacion(int id_internacion) {
		this.id_internacion = id_internacion;
	}

	public Set<TramiteExamenDatoLinea> getTramiteExamenDatoLineas() {
		return tramiteExamenDatoLineas;
	}

	public void setTramiteExamenDatoLineas(Set<TramiteExamenDatoLinea> tramiteExamenDatoLineas) {
		this.tramiteExamenDatoLineas = tramiteExamenDatoLineas;
	}

	 

	

}
