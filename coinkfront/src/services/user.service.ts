import api from "./api";
import type { User } from "../pages/UserList";

const USERS_ENDPOINT = import.meta.env.VITE_ENDPOINT_USERS;

interface CreateUserDto {
  name: string;
  phone: string;
  address: string;
  municipalityId: number;
}

export const UserService = {
  async getAll(): Promise<User[]> {
    const { data } = await api.get<any>(USERS_ENDPOINT);

    return data.data.map((u: any) => ({
      id: Number(u.idUser),
      name: u.name,
      phone: u.phone,
      address: u.address,
      municipalityId: u.municipalityId,
    }));
  },

  async create(payload: CreateUserDto): Promise<void> {
    await api.post(USERS_ENDPOINT, payload);
  },
};
