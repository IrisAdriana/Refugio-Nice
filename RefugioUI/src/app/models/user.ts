import { Data } from "@angular/router";

type User = {
    idUsuario?: number;
    Nombres: string;
    Apellidos: string;
    Email: string;
    Fecharegistro: Date;
    Estado: string;
    Cuenta: string;
    Contrasenia: string;

};

export default User;