const PROXY_CONFIG = [
  {
    context: [
      "/api/ranobes",
    ],
    target: "https://localhost:7129",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
