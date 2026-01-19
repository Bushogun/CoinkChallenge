import { Form, Input, Button, Card, message, InputNumber, Select } from "antd";
import { UserService } from "../../services/user.service";
import { useEffect, useState } from "react";
import { MunicipalityService } from "../../services/municipality.service";

interface FormData {
  name: string;
  phone: string;
  address: string;
  municipalityId: number;
}

interface Municipality {
  id: number;
  name: string;
}

export default function UserForm() {
  const [form] = Form.useForm<FormData>();
  const [municipalities, setMunicipalities] = useState<Municipality[]>([]);
  const [loadingMunicipalities, setLoadingMunicipalities] = useState(false);
  
    useEffect(() => {
    setLoadingMunicipalities(true);
    MunicipalityService.getAll()
      .then(setMunicipalities)
      .catch(() => message.error("Error loading municipalities"))
      .finally(() => setLoadingMunicipalities(false));
  }, []);
  
  const onFinish = async (values: FormData) => {
    try {
      await UserService.create(values);
      message.success("User created");
      form.resetFields();
    } catch (err) {
      message.error("Error creating user");
      console.error(err);
    }
  };

  return (
    <Card
      title="Create user"
      style={{ maxWidth: 420, margin: "0 auto", marginTop: 50 }}
    >
      <Form form={form} layout="vertical" onFinish={onFinish}>
        <Form.Item label="Name" name="name" rules={[{ required: true }]}>
          <Input />
        </Form.Item>

        <Form.Item
          label="Phone"
          name="phone"
          rules={[{ required: true, message: "Phone is required" }]}
        >
          <Input
            inputMode="numeric"
            onKeyDown={(e) => {
              if (
                !/[0-9]/.test(e.key) &&
                e.key !== "Backspace" &&
                e.key !== "Delete" &&
                e.key !== "ArrowLeft" &&
                e.key !== "ArrowRight"
              ) {
                e.preventDefault();
              }
            }}
          />
        </Form.Item>

        <Form.Item label="Address" name="address" rules={[{ required: true }]}>
          <Input />
        </Form.Item>

      <Form.Item
          label="Municipality"
          name="municipalityId"
          rules={[{ required: true, message: "Municipality is required" }]}
        >
          <Select
            placeholder="Select a municipality"
            loading={loadingMunicipalities}
            options={municipalities.map((m) => ({
              label: m.name,
              value: m.id,
            }))}
          />
        </Form.Item>

        <Form.Item>
          <Button type="primary" htmlType="submit" block>
            Submit
          </Button>
        </Form.Item>
      </Form>
    </Card>
  );
}
