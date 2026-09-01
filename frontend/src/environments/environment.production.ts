export const environment = {
  production: true,
  /**
   * TODO(maistrynia): REPLACE-ME before the first production deploy —
   * Railway API URL for this shop. Must NOT point at the Файно натурально API.
   */
  apiBaseUrl: 'https://REPLACE-ME-api.up.railway.app',
  /** Hardcoded intentionally for canonical/hreflang/og:url — do not use document.location. */
  /** TODO(maistrynia): REPLACE-ME — production domain, e.g. https://maistrynia.com.ua */
  siteOrigin: 'https://REPLACE-ME-domain',
} as const;
