export const environment = {
  production: true,
  apiBaseUrl: 'https://maistrynia-berehove-production.up.railway.app',
  /** Hardcoded intentionally for canonical/hreflang/og:url — do not use document.location. */
  /** TODO(maistrynia): switch to the custom domain once it is connected. */
  siteOrigin: 'https://maistrynia-berehove.vercel.app',
} as const;
