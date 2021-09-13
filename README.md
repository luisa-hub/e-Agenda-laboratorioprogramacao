<h1 align="center">e-Agenda</h1>

Sumário
=================
<!--ts-->
   * [Sobre](#sobre)
       * [Tecnologia](#tecnologia)
   * [Conhecendo o sistema](#conhecendo-o-sistema)
   * [Cadastro de Tarefas](#cadastro-de-tarefas)
   * [Cadastro de Contatos](#cadastro-de-contatos)
   * [Cadastro de Compromissos](#cadastro-de-compromissos)
   * [Internacionalização](#internacionalização)

<!--te-->


  ### Sobre
  
  <img src="https://user-images.githubusercontent.com/72579773/133004016-b4bbf474-a4dc-4974-8b7b-36df8ffb99e4.png"  align="middle" /> 
  
 **Figura 1 - Página inicial do sistema e-Agenda**
 
  
   O e-Agenda é um software de gestão de tarefas, contatos e compromissos, onde o usuário pode registrar e controlar sua rotina de maneira simples e eficiente. Este software foi desenvolvido pelos alunos Leandro Fontana e Luisa Farias de Macedo para a matéria de Laboratório de Programação, no ano de 2021.
   
   
  ### Tecnologia
  O software foi desenvolvido utilizando a tecnologia .Net Framework versão 4.7.2, com a linguagem de programação C#, e pode ser executado em sistemas Windows. Além disso, a persistência dos dados é garantida através do SQLServer. 
  É preciso utilizar o Visual Studio para executar o programa.
 
  
  
  ### Conhecendo o Sistema
  O e-Agenda é dividido em três módulos distintos: Tarefas, Contatos e Compromissos. 

Nas tarefas, podem-se cadastrar tarefas, e visualizar tarefas concluídas e pendentes, bem como editar e excluir as mesmas. A geração do relatório está disponível para cada tipo de tarefa. Os contatos possuem também opções de edição, exclusão, visualização e cadastro. A geração de relatórios para o contato se encontra na página do contato.

Os compromissos possuem opções de edição, exclusão, visualização, cadastro, além de permitir associação entre contatos e compromissos. A realização do relatório dos compromissos está disponível na página do compromisso. 

Cada módulo será analisado de maneira mais detalhada nos próximos capítulos.

  ### Cadastro de Tarefas
   <img src="https://user-images.githubusercontent.com/72579773/133004036-c31e8c47-8ef0-45ce-8347-35062aa588f7.png" />
   
   **Figura 2 - Visão Geral do Cadastro de Tarefas**
   
  O cadastro de tarefas possui dois tipos de tarefas, que podem ser navegadas a partir dos menus na parte superior: Pendentes e Concluídas. Para registrar uma nova tarefa, digite as informações de nome e escolha a prioridade da tarefa (que pode ser Alta, Baixa ou Normal). Depois, clique em gravar, e a tarefa aparecerá em Tarefas Pendentes. Uma mensagem de sucesso aparecerá caso todos os campos tenham sido registrados corretamente.
  
   <img src="https://user-images.githubusercontent.com/72579773/133004413-4e19d188-88fc-49ef-aa13-0ccc3dc7decc.png" />
   
   **Figura 3 - Campos para o registro de Tarefas**
   
   A fim de editar uma tarefa, é preciso selecionar uma tarefa existente no DataGrid de visualização, e inserir as novas informações da tarefa nos campos de registro. Clicando em "Editar", a tarefa atualizada será registrada. Se o usuário clicar duas vezes em cima da tarefa que deseja editar, os campos serão automaticamente preenchidos.
   
   Para definir uma tarefa como "Concluída", é preciso que sua porcentagem seja "100", o que automaticamente adicionará a tarefa ao DataGrid de tarefas concluídas. Para editar a porcentagem da tarefa, o usuário precisa selecionar a tarefa que deseja editar, digitar o valor no campo de porcentagem e clicar no botão de "Atualizar Porcentagem". Uma mensagem de sucesso será enviada caso todos os campos estejam válidos.
   
   <img src="https://user-images.githubusercontent.com/72579773/133004599-f92bf298-7d3d-4ead-bdc0-5cfeee3c0469.png" />
   
 **Figura 4 - Campo para a edição do percentual**
 
 Para excluir uma tarefa, o usuário deve selecionar a tarefa no DataGrid e confirmar a mensagem que aparecerá na tela. O DataGrid será atualizado e a tarefa será excluída do banco.
 
  <img src="https://user-images.githubusercontent.com/72579773/133004723-d6613469-dc29-4a22-92fb-6dac010c479d.png" />
 
 **Figura 5 - Mensagem de confirmação de exclusão**
 
 Por fim, o usuário tem a possibilidade de gerar um PDF, clicando no botão "Exportar". O usuário pode Exportar tanto as tarefas pendentes quanto as concluídas, e os arquivos ficarão salvos na pasta de "Relatórios" do programa.  
  
  
  ### Cadastro de Contatos
  
  <img src="https://user-images.githubusercontent.com/72579773/133004067-ef76a59b-c083-4d99-9ab1-d9f5f84cbc02.png" />
  
  **Figura 6 - Visão geral do cadastro de Contatos**
  
  Para inserir um novo contato, o usuário deve preencher todos os campos pedidos pelo sistema e clicar no botão "Gravar". Uma mensagem de Sucesso aparecerá na tela e o DataGrid será atualizado.
  
  <img src="https://user-images.githubusercontent.com/72579773/133004676-88b331a8-3584-4509-a665-43f0e2319614.png" />
  
 **Figura 7 - Campos de preenchimento do contato**
  
  Para editar um contato, o usuário pode clicar duas vezes no contato que deseja excluir, o que preencherá automaticamente os campos. Depois, clicando em Editar o contato será atualizado de acordo com as mudanças, e uma mensagem de Sucesso aparecerá na tela. É importante deixar o contato selecionado na hora de editá-lo. O mesmo vale para a função de Excluir, o contato deverá ser selecionado e confirmar a mensagem de exclusão
  
  Por fim, o usuário tem a possibilidade de gerar um PDF, clicando no botão "Exportar". Os arquivos ficarão salvos na pasta de "Relatórios" do programa.  
  
  ### Cadastro de Compromissos
  
  <img src="https://user-images.githubusercontent.com/72579773/133004055-272acb64-7872-48e9-9176-6b2c45cd85a7.png" />
  
 **Figura 8 - Visão geral do cadastro de compromissos**
  
  O cadastro de compromissos difere-se das tarefas por: conter um loca ou um link, hora início e hora término, além de ter a possibilidade de associar um contato existente ao compromisso. Para inserir um novo compromisso, o usuário deve preencher todos os campos, e pode ou não associar um contato relacionado ao compromisso. Clicando em gravar, o compromisso aparecerá na tabela de compromissos e uma mensagem de sucesso aparecerá na tela.
  
  <img src="https://user-images.githubusercontent.com/72579773/133005227-ddef6b5e-ad2f-47a0-8e2c-1c3c8bcbc7d7.png" />
  
  **Figura 9 - Campos de preenchimento do compromisso**
  
  Além disso, o compromisso possui outras duas possibilidades: filtrar compromissos no passado, a partir de uma data específica, e filtrar compromissos no futuro, a partir de duas data que o usuário passa ao sistema. Por exemplo, se o usuário quiser ver compromissos anteriores ao mês de fevereiro, ele pode selecionar o dia primeiro de fevereiro e aparecerão todos os compromissos passados. No caso dos futuros, se o usuário desejar ver compromissos da semana, pode selecionar uma semana a frente e todos os compromissos daquela semana serão filtrados. 
  
  <img src="https://user-images.githubusercontent.com/72579773/133005290-5cd3c6a5-8b55-4516-9c7f-1cbf1c3d873e.png" />
  
  **Figura 10 - Filtro dos compromissos passados**
  
  <img src="https://user-images.githubusercontent.com/72579773/133005307-c650d9f6-f3af-43bb-919f-637a98096849.png" />
  
  **Figura 11 - Filtro dos compromissos futuros**
  
  Para editar compromissos, como já explicado, basta que o usuário selecionado o compromisso desejado, preencha os campos que deseje editar e clique no botão "Editar". Se o usuário clicar duas vezes no compromisso escolhido, os campos serão preenchidos automaticamente. 
  
  Para excluir um compromisso, o usuário deve selecionar o compromisso que deseja excluir e clicar no botão "Excluir" no menu de Compromissos. 
  
  O usuário pode exportar PDFs tanto de todos os compromissos, como se compromissos passados e futuros clicando no botão exportar específico de cada menu. Os PDFs ficarão salvos na pasta de Relatórios do programa. 
  
  
  ### Internacionalização
  
  <img src="https://user-images.githubusercontent.com/72579773/133005374-b1d95d54-9fbb-465b-bbfa-c61b700dc852.png" />
  
**Figura 12 - e-Agenda na língua inglesa**
 
 Para a internacionalização do software, escolhemos a língua inglesa. Clicando no botão inicial do e-Agenda, o usuário consegue alterar a língua para português ou inglês, o que alterará todos os formulários. 

