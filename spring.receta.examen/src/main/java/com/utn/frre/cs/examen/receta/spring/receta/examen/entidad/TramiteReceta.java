package com.utn.frre.cs.examen.receta.spring.receta.examen.entidad;

import java.util.Date;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

/**
 * TramiteReceta: Representa el medicamento/s dado  en una
 * internacion en particular solicitada por un deteminado medico/s . 
 * Probablemente necesite mas informacion de la del grupo de
 * medicamentos para mostrar o hacer alguna validacion.
 * 
 * @author Gonza
 * @version 1.0
 */

@Entity
@Table(name = "Tramite_Receta")
public class TramiteReceta {

	/**
	 * Es el id que identifica a una tramite receta univocamente.
	 */
    
	@Id
	@GeneratedValue(strategy = GenerationType.AUTO)
	@Column(name = "IDE_RECETA")
	private Long ide_receta;

	/**
	 * Es el id que identifica a el medico que receto este medicamento
	 */
	private int ide_personal_med;

	/**
	 * Es el id que identifica a una la presentacion(inyectable,pastillas,pomada)
	 * del medicamento
	 */
	private int ide_presentacion_med;

	/**
	 * Es el id que identifica a un medicamento en particular
	 */
	private int ide_med;

	/**
	 * Es la fecha en la que se tiene que iniciar el tratamiento con el medicamento.
	 */
	private Date fecha_inicio_med;

	/**
	 * Es la cantidad/dosis/tiempo en que se debe administrar el medicamento
	 */
	private String descripcionDosis;

	/**
	 * Representa a que internacion de este paciente se refiere este tramite de
	 * receta
	 */
	private int id_internacion;

	

	/**
	 * Constructor por defecto de la clase TramiteReceta
	 */
	public TramiteReceta() {

	}

	/**
	 * Constructor de la clase TramiteReceta necesario para un insert
	 */
	public TramiteReceta(int ide_personal_med, int ide_presentacion_med, int ide_med, Date fecha_inicio_med,
			String descripcionDosis, int id_internacion) {
		super();
		this.ide_personal_med = ide_personal_med;
		this.ide_presentacion_med = ide_presentacion_med;
		this.ide_med = ide_med;
		this.fecha_inicio_med = fecha_inicio_med;
		this.descripcionDosis = descripcionDosis;
		this.id_internacion = id_internacion;
		
	}

	/**
	 * Constructor de la clase TramiteReceta necesario para un update
	 */
	public TramiteReceta(Long ide_receta, int ide_personal_med, int ide_presentacion_med, int ide_med,
			Date fecha_inicio_med, String descripcionDosis, int id_internacion) {
		super();
		this.ide_receta = ide_receta;
		this.ide_personal_med = ide_personal_med;
		this.ide_presentacion_med = ide_presentacion_med;
		this.ide_med = ide_med;
		this.fecha_inicio_med = fecha_inicio_med;
		this.descripcionDosis = descripcionDosis;
		this.id_internacion = id_internacion;
		
	}

	// Getters y Setters------------------------------------------------

	public Long getIde_receta() {
		return ide_receta;
	}

	public void setIde_receta(Long ide_receta) {
		this.ide_receta = ide_receta;
	}

	public int getIde_personal_med() {
		return ide_personal_med;
	}

	public void setIde_personal_med(int ide_personal_med) {
		this.ide_personal_med = ide_personal_med;
	}

	public int getIde_presentacion_med() {
		return ide_presentacion_med;
	}

	public void setIde_presentacion_med(int ide_presentacion_med) {
		this.ide_presentacion_med = ide_presentacion_med;
	}

	public int getIde_med() {
		return ide_med;
	}

	public void setIde_med(int ide_med) {
		this.ide_med = ide_med;
	}

	public Date getFecha_inicio_med() {
		return fecha_inicio_med;
	}

	public void setFecha_inicio_med(Date fecha_inicio_med) {
		this.fecha_inicio_med = fecha_inicio_med;
	}

	public String getDescripcionDosis() {
		return descripcionDosis;
	}

	public void setDescripcionDosis(String descripcionDosis) {
		this.descripcionDosis = descripcionDosis;
	}

	public int getId_internacion() {
		return id_internacion;
	}

	public void setId_internacion(int id_internacion) {
		this.id_internacion = id_internacion;
	}

	

	

}
