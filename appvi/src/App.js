import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css'
import axios from 'axios'
import { useState, useEffect } from 'react';
import Navbar from './components/Navbar';
import Baixo from './components/baixo';

function App() {

  const baseUrl = "https://localhost:44368/api/Destinos";

  const [data, setData] = useState([]);




  const pedidoGet = async()=>{
    await axios.get(baseUrl)
    .then(response => {
      setData(response.data);
    }).catch(error =>{
      console.log(error);
    });

  }



  useEffect(()=>{
    pedidoGet();
  })

  const [destinoSelecionado, setDestinoSelecionado]=useState({
     id: '',
     nome: '',
     valor: '',
     localidade: '',
     proprietario: ''    
  })

  const handleChange=e=>{
    const {name, value}=e.target;
    setDestinoSelecionado({
      ...destinoSelecionado,
      [name]: value
    });
    console.log(destinoSelecionado);
  }

  return (
    <div className="App text-black">
      <Navbar />
      <br/>
      <br/>
      <header className='app-header'>
        <h3>Destinos disponíveis:</h3>
        </header>
      <br/>
      <table class="table table-bordered">
         <thead>
              <tr>
                <th scope="col">id</th>
                <th scope="col">Nome</th>
                <th scope="col">Valor</th>
                <th scope="col">Localidade</th>
                <th scope="col">Proprietário</th>
              </tr>
          </thead>
        <tbody>
          {data.map(destino=>(
           <tr key={destino.id}>
             <td>{destino.id}</td>
             <td>{destino.nome}</td>
             <td>{destino.valor}</td>
             <td>{destino.localidade}</td>
             <td>{destino.proprietario}</td>
           </tr>
          ))}
        </tbody>
      </table>
      <Baixo />
    </div> 
  )
}

export default App;
