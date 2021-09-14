# Alu

  O Assiste Logo Uma (que dá origem ao acrônimo título) trata-se de uma aplicação console destinada ao cadastro de informações sobre séries.
	O termo séries nesse contexto refere-se a histórias (ficcionais ou não) compostas de vídeo e imagem e distribuidas em várias partes (chamadas comumente de episódios), estas eventualmente podem ser dividadas em mais de um conjunto de episódios, sendo cada um destes chamado de temporada!
	Conforme nossos stakeholders de projeto: Eliézer Zapelão (responsável técnico) e Natália Fernandes (responsável UI/UX), os requisitos indispensáveis para a aplicação foram:
                                                                              
	* Implementação de um sistema CRUD. 
	* Utilização de classes abstratas.
	* Utilização de interfaces.
	* Inclusão dos arquivos do projeto na plataforma cliente.
	* Inclusão de projeto em uma plataforma de versionamento remoto.

##Tecnologia utilizada:

C#

##Desafios encontrados e decisões tomadas para solução:

Problema: editar as cores do conteúdo da janela console!
Solução: Utilizadas as propriedades BackgroundColor e Clear juntamente com a propriedade ForegroundColor da classe Console para editar a cor de fundo da janela de aplicação e a fonte respectivamente! 
Material de apoio usado: https://docs.microsoft.com/pt-br/dotnet/api/system.console.backgroundcolor?view=net-5.0

Problema: editar a disposição geral do conteúdo da janela console!
Solução: Empregados recursos de formatação inline  como \n para newlines e \t para tabulações visando alinhar o conteúdo próximo ao meio da janela!
Pendente: adequação da disposição das informações exibidas na linha descrição na invocação do método visualizar série!

Problema: editar o tamanho e a posição da janela da aplicação!
Solução: Atribuido valor a propriedade WindowWidth da classe Console viabilizando adequação da largura da janela da aplicação
Pendente: adequar a posição da janela de console durante a atividade da aplicação. Nenhum material para consulta encontrado sobre o tema até o momento.

Problema: Como especificar um ícone para uma aplicação de console?
Solução:  Será tratado em futuras atualizações. Material de apoio não encontrado!

Problema: Presença de funções na classe Program.
Solução:  Será gerada classe para abrigar as funções como métodos, garantindo assim uma divisão adequadas entre a camada responsável pela apresentação de dados ao usuário da camada de dados.

Problema: Sistema acatando inclusão de informações não concernentes ao contexto (apenas números, espaços vazios)
Solução: Serão implementadas linhas de verificação de imputs para os campos descrição e ano.

Autor: Robson Silva
https://linkedin.com/in/robson-silva-129ba8120

