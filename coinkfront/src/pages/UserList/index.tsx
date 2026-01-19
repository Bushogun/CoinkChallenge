import { useEffect, useState } from "react";
import { Table } from "antd";
import type { ColumnsType } from "antd/es/table";
import { UserService } from "../../services/user.service";
import Header from "../../components/Header/Header";
import Layout from "../../components/Layout/Layout";

export interface User {
  id: number;
  name: string;
  phone: string;
  address: string;
  municipalityId: number;
}

function UserList() {
  const [data, setData] = useState<User[]>([]);
  const [loading, setLoading] = useState(false);

  useEffect(() => {
    setLoading(true);
    UserService.getAll()
      .then(setData)
      .finally(() => setLoading(false));
  }, []);

  const columns: ColumnsType<User> = [
    {
      title: "ID",
      dataIndex: "id",
      key: "id",
      width: 80,
    },
    {
      title: "Nombre",
      dataIndex: "name",
      key: "name",
    },
    {
      title: "Teléfono",
      dataIndex: "phone",
      key: "phone",
    },
    {
      title: "Dirección",
      dataIndex: "address",
      key: "address",
    },
    {
      title: "Municipio",
      dataIndex: "municipalityId",
      key: "municipalityId",
      width: 120,
    },
  ];

  return (
    <Layout>
      <Header />
      <section className="min-h-screen pt-20 px-6 text-gray-200">
        <div className="mb-4" style={{ maxWidth: "800px", margin: "0 auto", paddingTop: "20px" }}>
        <Table<User>
          rowKey="id"
          columns={columns}
          dataSource={data}
          loading={loading}
          pagination={{ pageSize: 10 }}
        />
        </div>
      </section>
    </Layout>
  );
}

export default UserList;
