import UserForm from "../../components/Form";
import Header from "../../components/Header/Header";
import Layout from "../../components/Layout/Layout";

function Home() {
  return (
    <Layout>
      <Header />
      <section className="min-h-screen pt-20 text-gray-200">
        <UserForm />
      </section>
    </Layout>
  );
}
export default Home;
