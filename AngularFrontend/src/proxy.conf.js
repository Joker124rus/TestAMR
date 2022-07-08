const PROXY_CONFIG = [
  {
    context: [
      "/api/ranobes",
      "/api/admin"
    ],
    target: "https://localhost:7129",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
