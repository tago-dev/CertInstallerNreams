# CertInstallerNreams

## 📋 Descrição

O **CertInstallerNreams** é uma ferramenta automatizada desenvolvida para resolver problemas de certificado relacionados ao **Filtro Web da Celepar** em escolas e núcleos da rede estadual de educação do Paraná.

Este utilitário permite a instalação automática do certificado necessário para o correto funcionamento do filtro web, eliminando erros de certificado que impedem o acesso à internet em ambientes educacionais.

## 🎯 Objetivo

- **Automatizar** a instalação do certificado do Filtro Web da Celepar
- **Resolver** erros de certificado que bloqueiam o acesso à internet
- **Simplificar** o processo de configuração em escolas e núcleos
- **Reduzir** a necessidade de intervenção técnica especializada

## 🏫 Público-Alvo

- **Escolas da rede estadual** do Paraná
- **Núcleos regionais de educação**
- **Administradores de rede** em ambientes educacionais
- **Técnicos de suporte** da área de educação

## ⚡ Funcionamento

O aplicativo:

1. **Baixa automaticamente** o certificado do Filtro Web da Celepar
2. **Instala o certificado** no repositório de certificados confiáveis do usuário
3. **Fornece feedback visual** sobre o status da operação
4. **Exibe mensagens informativas** sobre o sucesso ou falha da instalação

## 🔧 Características Técnicas

- **Plataforma**: Windows (.NET 8)
- **Interface**: WPF (Windows Presentation Foundation)
- **Linguagem**: C# 12.0
- **Instalação**: Download automático via HTTPS
- **Armazenamento**: Certificado instalado no repositório local do usuário

## 💻 Requisitos do Sistema

### Windows
- **Sistema Operacional**: Windows 10/11
- **Framework**: .NET 8 Runtime
- **Privilégios**: Execução como administrador (recomendado)
- **Conexão**: Internet ativa para download do certificado

## 📦 Instalação e Uso

### Windows (Disponível)

1. **Download**: Baixe o arquivo `.exe` mais recente
2. **Execução**: Execute o programa (preferencialmente como administrador)
3. **Instalação**: Clique no botão "Instalar Certificado"
4. **Aguarde**: O processo de download e instalação será executado automaticamente
5. **Reinicie**: Reinicie o navegador para aplicar as alterações

### Linux Mint (Em Desenvolvimento)

🚧 **Status**: Versão em desenvolvimento  
📅 **Previsão**: Disponível em breve

## 🛡️ Segurança

- **Certificado oficial** da Celepar
- **Download seguro** via HTTPS
- **Instalação local** no repositório do usuário
- **Código fonte aberto** para auditoria

## ⚠️ Solução de Problemas

### Erros Comuns

**Erro de Conexão**
- Verifique a conexão com a internet
- Tente novamente após alguns minutos

**Erro de Permissão**
- Execute o programa como administrador
- Verifique se o usuário tem privilégios para instalar certificados

**Certificado não reconhecido**
- Reinicie completamente o navegador
- Limpe o cache do navegador se necessário

## 🤝 Suporte

Para suporte técnico ou dúvidas:

- **Repositório**: [GitHub - CertInstallerNreams](https://github.com/tago-dev/CertInstallerNreams)
- **Issues**: Reporte problemas na seção Issues do GitHub
- **Documentação**: Consulte este README para informações técnicas

## 📋 Roadmap

- [x] Versão Windows (.exe)
- [ ] Versão Linux Mint
- [ ] Interface multilíngue
- [ ] Instalação via linha de comando
- [ ] Atualização automática

## 🔄 Versões

- **v1.0**: Versão inicial para Windows
- **v2.0** (planejada): Suporte para Linux Mint

## 📄 Licença

Este projeto está licenciado sob a licença MIT - veja o arquivo LICENSE para detalhes.

---

> **Nota**: Este utilitário foi desenvolvido especificamente para resolver problemas de certificado do Filtro Web da Celepar em ambientes educacionais da rede estadual do Paraná.