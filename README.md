Após baixar o projeto configure o banco de dados na sua maquina, seguindo o padrao que esta no codigo
No console do gerenciador de pacotes de um "Update-database" para inserir os dados do banco

caso necessario crie uma consulta e coloque:
delete from Estatisticas;
delete from Partidas;
delete from ComissaoTecnicas;
delete from Jogadors;
delete from Times;

esse codigo irá excluir os dados da tabela, em seguida execute o comando "Update-database"

No site vá em Partidas(com os times gerados) e clique para gerar as partidas, apos ter gerado, você pode voltar no banco de dados, criar uma nova consulta e inserir o seguinte comando:
UPDATE Partidas
SET Resultado = 2
WHERE Rodada BETWEEN 1 AND 37;

select * from Partidas;

Esse comando colocara todas as partidas das rodadas 1 a 37 como empate (para ficar mais rapido de testar), em seguida, volte no site e cadastre as ultimas 10 partidas, selecionando quem fez os gols e etc...
apos ter feito isso, voce pode ir para a tela inicial e ver a classificação, o botão "Ver campeão" só funciona caso os 20 times ja tenham jogado os 38 jogos.
