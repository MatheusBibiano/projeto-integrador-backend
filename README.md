# Projeto Integrador - Dotnet

### 📌 Conteúdo

* [Status](#status)
* [Características](#características)
* [Requisitos](#requisitos)
* [Tecnologias](#tecnologias)
* [Autor](#autor)
* [Licença](#licença)
<br/>

---

### Status

Projeto em construção 🛠️
<br/>

---

### Características

- [x] **API**
<br/>

---

### Requisitos

1. Cria conexão com o banco:
```bash
    $ dotnet ef dbcontext scaffold "Server=192.168.0.115;User=guest;Password=123;Database=letmerate" "Pomelo.EntityFrameworkCore.MySql" -o Models -c BDContexto -f
```

2. Compila o projeto:
```bash
    $ dotnet build
```

3. Executa o projeto:
```bash
    $ dotnet run --urls https://0.0.0.0:3001
```
<br/>

---

### Tecnologias

As seguintes tecnologias foram utilizadas na construção do projeto:

- [DotNet](https://dotnet.microsoft.com/en-us/)

<br/>

---

### Autor

| Matheus Bibiano                                       | Matheus Cereda                                         | Vinícius Fonseca                                       
|-------------------------------------------------------|--------------------------------------------------------|--------------------------------------------------------|
| <img src="https://github.com/MatheusBibiano.png" width="150" height="150">| <img src="https://github.com/MatheusCereda.png" width="150" height="150">| <img src="https://github.com/vinioli01.png" width="150" height="150">
| [<img src="https://img.shields.io/badge/linkedin-%230077B5.svg?&style=for-the-badge&logo=linkedin&logoColor=white" />](https://www.linkedin.com/in/matheus-bibiano-alves)|[<img src="https://img.shields.io/badge/linkedin-%230077B5.svg?&style=for-the-badge&logo=linkedin&logoColor=white" />](https://www.linkedin.com/in/matheus-henrique-cereda-monteiro-448b78223/)|[<img src="https://img.shields.io/badge/linkedin-%230077B5.svg?&style=for-the-badge&logo=linkedin&logoColor=white" />](https://www.linkedin.com/in/)|
<br/>

---

### Licença

[MIT](https://choosealicense.com/licenses/mit/)

