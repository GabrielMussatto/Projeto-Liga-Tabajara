# Projeto Liga Tabajara de Futebol

Este é um sistema web de gestão de uma liga de futebol, desenvolvido em ASP.NET MVC com Entity Framework. Nele você pode cadastrar times, jogadores, comissão técnica, gerar automaticamente o calendário de partidas estilo Brasileirão, registrar resultados, ver classificação e acompanhar estatísticas de artilheiros.

---

## Funcionalidades

1. **Times**
   - CRUD completo de times (Nome, Cidade, Estado, Ano de Fundação, Estádio, Capacidade, Cores do uniforme).
   - Validação automática do “Status” do time (apto ou não), com base em:
     - Mínimo de 30 jogadores.
     - Presença de todas as posições obrigatórias.
     - Mínimo de 5 membros na comissão técnica, sem cargos duplicados.
   - Filtros de busca por Nome e Estádio.

2. **Jogadores**
   - CRUD completo de jogadores (Nome, Data de Nascimento, Nacionalidade, Posição, Número, Altura, Peso, Pé Preferido, Time).
   - Filtros de busca por Nome, Posição e Pé Preferido.
   - Estilo de listagem inspirado nas tabelas do campeonato.

3. **Comissão Técnica**
   - CRUD completo de profissionais (Nome, Cargo, Data de Nascimento, Time).
   - Validação para não duplicar cargo em um mesmo time.
   - Filtro de busca por Nome e Cargo.
   - Mesma identidade visual das demais tabelas.

4. **Partidas**
   - Geração automática de 38 rodadas (turno e returno) entre 20 times, usando algoritmo de round‑robin:
     - Cada time enfrenta todos os outros 19 vezes como mandante e 19 como visitante.
     - Datas espaçadas em semanas.
   - Registro de placares:
     - Interface de digitação de gols por jogador de cada equipe.
     - Resultados calculados (vitória mandante, visitante ou empate).
     - Estatísticas individuais de gols armazenadas.
   - Filtros de busca na listagem de partidas por time (mandante ou visitante) e estádio.
   - Todos os campos “Gols” e “Resultado” aparecem como `--`/“Não realizada” até o registro oficial.

5. **Classificação da Liga**
   - Cálculo de pontos, vitórias, empates, derrotas, gols pró, contra e saldo.
   - Ordenação por pontos e saldo de gols.
   - Tabela estilizada como no Brasileirão, com faixas coloridas para:
     1–4 (Libertadores Grupos), 5–6 (Pré‑Libertadores), 7–12 (Sul‑Americana) e 17–20 (Rebaixamento).
   - Legenda explicativa abaixo da tabela.

6. **Artilheiros**
   - Exibição detalhada de estatísticas por rodada.
   - Lista consolidada de artilheiros do campeonato (total de gols por jogador e time).
   - Ordenação dentro de cada rodada por número de gols (do maior para o menor).

7. **Home / Página Inicial**
   - Status geral da liga (apta ou não para iniciar).
   - Botão “Ver Campeão” habilitado apenas quando todas as partidas tiverem resultado lançado, exibindo um diálogo com o time campeão.
   - Tabela de classificação exibida logo na abertura do sistema.

8. **UI / Estilo**
   - Layout criado com Bootstrap para responsividade.
   - Todas as tabelas compartilham identidade (cores, hover, zebra‑striping, alinhamentos).
   - Formulários centralizados e campos com tamanho uniforme.
   - Botões claros e consistentes: ações CRUD, geração de calendário, filtros.

---

## Estrutura do Projeto

- **Controllers/**
  - `HomeController` → Lógica de inicialização da liga, classificação e diálogo de campeão.  
  - `TimesController`, `JogadorsController`, `ComissaoTecnicasController`, `PartidasController`, `EstatisticasController` → CRUD e funcionalidades específicas.
- **Models/**
  - `Time`, `Jogador`, `ComissaoTecnica`, `Partida`, `Estatistica`, `ClassificacaoTime`, `RegistrarPlacarViewModel` e enums auxiliares (`Posicao`, `PePreferido`, `Resultado`, `Cargo`).
- **Views/**
  - Pastas separadas para cada controller, com visões de _Index_, _Create_, _Edit_, _Details_ e _Delete_ totalmente estilizadas.
  - Partial views e estilos inline nas próprias views `.cshtml`.

---

## Como executar

1. **Pré-requisitos**  
   - Visual Studio 2019+  
   - .NET Framework 4.7.2+  
   - SQL Server LocalDB (ou outra instância configurada no `web.config`).

2. **Configuração**  
   - Faça clone deste repositório.  
   - Abra no Visual Studio, restaure os pacotes NuGet.  
   - Atualize a connection string em `Web.config` se necessário.

3. **Criação do banco**  
   - Rodar a migration ou deixar o EF criar o banco automaticamente pelo _Database Initializer_.

4. **Executar**  
   - Pressione F5 ou `Ctrl+F5` para iniciar em IIS Express.  
   - Navegue até `~/`, cadastre os times, jogadores e comissão; gere o calendário; registre resultados; confira classificação e artilharia.

---

## Licença

Este projeto está sob a [MIT License](LICENSE).

---
*Desenvolvido para o “Projeto Liga Tabajara de Futebol” – Gerencie sua liga com praticidade e visual moderno!*  

---
## Prática direta simplificada

Após baixar o projeto configure o banco de dados na sua maquina, seguindo o padrao que esta no codigo
No console do gerenciador de pacotes de um "Update-database" para inserir os dados do banco

caso necessario crie uma consulta e coloque:
>delete from Estatisticas;
delete from Partidas;
delete from ComissaoTecnicas;
delete from Jogadors;
delete from Times;

esse codigo irá excluir os dados da tabela, em seguida execute o comando "Update-database"

No site vá em Partidas(com os times gerados) e clique para gerar as partidas, apos ter gerado, você pode voltar no banco de dados, criar uma nova consulta e inserir o seguinte comando:
>UPDATE Partidas
SET Resultado = 2
WHERE Rodada BETWEEN 1 AND 37;
select * from Partidas;

Esse comando colocara todas as partidas das rodadas 1 a 37 como empate (para ficar mais rapido de testar), em seguida, volte no site e cadastre as ultimas 10 partidas, selecionando quem fez os gols e etc...
apos ter feito isso, voce pode ir para a tela inicial e ver a classificação, o botão "Ver campeão" só funciona caso os 20 times ja tenham jogado os 38 jogos.
