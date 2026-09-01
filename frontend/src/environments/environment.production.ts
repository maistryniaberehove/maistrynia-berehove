export const environment = {
  production: true,
  // TODO: point to new Railway API when Maistrynia backend is deployed
  apiBaseUrl: 'https://faino-naturalno-production.up.railway.app',
  /** Hardcoded intentionally for canonical/hreflang/og:url — do not use document.location. */
  // TODO: set production domain when available
  siteOrigin: 'http://localhost:4200',
} as const;
