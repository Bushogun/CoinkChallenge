import api from "./api";

export interface Municipality {
  id: number;
  name: string;
}

interface MunicipalityApiResponse {
  data: Municipality[];
  totalRecords: number;
  message: string;
}

const MUNICIPALITIES_ENDPOINT =
  import.meta.env.VITE_ENDPOINT_MUNICIPALITIES;

export const MunicipalityService = {
  async getAll(): Promise<Municipality[]> {
    const { data } = await api.get<MunicipalityApiResponse>(
      MUNICIPALITIES_ENDPOINT
    );

    return data.data;
  },
};
