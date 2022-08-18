import { Data } from "@angular/router";

type User = {
    idUsuario?: number;
    Nombres: string;
    Apellidos: string;
    Email: string;
    Fecharegistro: Date;
    Estado: string;
    Cuenta:string;
    Contrasena: string;

    
};

export default User;