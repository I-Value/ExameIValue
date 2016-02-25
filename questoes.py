foo = ['t','s','w','l','h']

#variaveis de quantidade das preposicoes, verbos e primeira pessoa
qtd_pre = 0
qtd_ver = 0
qtd_pri = 0

#abrir arquivo txt e fazer leitura de linha analisando cada palavra
with open('textoB.txt','r') as file:
    for line in file:
        for word in line.split():
           if len(word) == 3 and 'm' not in word and word.endswith(tuple(foo)):
               qtd_pre += 1
           elif len(word) > 7 and word.endswith(tuple(foo)):
               qtd_ver += 1
               if word.startswith(tuple(foo)):
                    qtd_pri += 1

        # imprimir respostas
        print('Analise texto B: \n{0} Preposicoes \n{1} Verbos  \n{2} Primeira pessoa'.format(qtd_pre, qtd_ver,qtd_pri))
