import { Iclientero } from "./iclientero";
import { Iclienters } from "./iclienters";

export interface ICadastro {
  id: number;
  id_cliente: number;
  cliente_ro: boolean;
  senha: string;
  email: string;
  cgcRo: Iclientero;
  cgcRs: Iclienters;
}
