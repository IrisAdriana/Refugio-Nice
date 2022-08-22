export interface Rescate {
  id_rescate?: number;
  nombre: string;
  id_tipo_rescate: number;
  estado: string;
  latitud: Float64Array;
  longitud: Float64Array;
  observaciones: string;
  fecha_rescate: Date;
}
