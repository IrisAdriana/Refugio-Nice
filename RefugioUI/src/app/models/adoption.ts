type Adoption = {
    id_mascota?: number;
    nombre: string;
    id_tipoMascota?: number;
    id_color?: number;
    id_raza?: number;
    fecha_nacimiento?: Date;
    raza: string;
    edad: number;
    genero: string;
    caracter: string;
    observaciones: string;
    recha_resgistro?: Date;
    url_foto: string;
    estado:string;
    
};

export default Adoption;
